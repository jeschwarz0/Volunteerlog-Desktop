using System;
using System.Collections.Generic;
using System.Data;
using MySQLDriverCS;

namespace libVL
{
    /// <summary>
    /// A interface class for the VolunteerLog Database
    /// </summary>
   public class VLDBCon
    {
       /// <summary>
       /// The max of "MediumLength" in MySQL
       /// </summary>
       private static int TEXT_FIELD_MAX = 16777215;
       /// <summary>
       /// The connection
       /// </summary>
       private MySQLConnection vlcon=new MySQLConnection(new MySQLConnectionString("127.0.0.1","VolunteerLog","appuser","w7txXWST37GZTvCf").AsString);
       /// <summary>
       ///  The format that the name may be sorted into, default first last
       /// @deprecated
       /// </summary>
       public enum user_output_type {INDEX_ONLY, FIRST_LAST, LAST_FIRST, FIRST_LAST_IDX, LAST_FIRST_IDX};
       /// <summary>
       /// Create a VLDBCon
       /// </summary>
       public VLDBCon() {
           if(!vlcon.State.Equals(System.Data.ConnectionState.Open))
               try
               {
                   vlcon.Open();
               }
               catch 
               {   
                   throw new DatabaseNotOpenException("The database could not be found on 127.0.0.1!");
               }
       }
      /// <summary>
      /// Closes the class
      /// </summary>
        public void close(){
            switch (vlcon.State) { 
                   case ConnectionState.Open:
                       try { vlcon.Close(); }
                       catch (Exception e){
                           System.Console.WriteLine(e.Message);
                       }
                       break;
                   case ConnectionState.Closed:
                       System.Console.WriteLine("The connection is already closed!");
                       break;
                   case ConnectionState.Connecting:case ConnectionState.Executing:case ConnectionState.Fetching:
                       System.Console.WriteLine("Unusual problem, " + vlcon.State.ToString());
                       break;
                }
            //dispose this class
            GC.SuppressFinalize(this);
        }
       /// <summary>
       /// Checks if the connection is active, unreliable @deprecated.
       /// </summary>
       /// <returns>Connection state is Open</returns>
       public Boolean active() {
           return vlcon.State.Equals(System.Data.ConnectionState.Open);
       }
       /// <summary>
       /// Filter Escapes(removes harmful html/sql characters)
       /// </summary>
       /// <param name="Data">The data to search</param>
       /// <returns>A cleaned string</returns>
       private static string filterEscape(string Data)
       {
           return MySQLUtils.HTMLEscapeSpecialCharacters(Data).Replace("'", "\\'");//real escape string and html char trimming
       }
       /// <summary>
       /// Parse the DateTime to a MySQL safe input string
       /// </summary>
       /// <param name="date">The DateTime input</param>
       /// <returns>A MySQL safe date string</returns>
       private static string MySQLSafeDate(DateTime date)
       {
           return String.Format("{0}-{1}-{2}", date.Year, date.Month, date.Day);
       }

       #region QueryData
       /// <summary>
       /// Gets a key for a new field(max+1)
       /// </summary>
       /// <param name="TableName">The name of the table</param>
       /// <param name="IndexFieldName">The name of the index field(LogID,VolunteerID,TaskID)</param>
       /// <returns>A key or null</returns>
       private int? getNewKey(string TableName, string IndexFieldName)
       {
           MySQLCommand mc = new MySQLCommand(String.Format("SELECT MAX({1}) FROM {0};", TableName, IndexFieldName), vlcon);
           int? rval;
           try{
               object qres = mc.ExecuteScalar();
               rval = qres.ToString() != "" ? (int?)qres : 0;
           }catch (MySQLException) {
               throw new DatabaseNotOpenException(); 
           }catch (Exception ex){
               rval = null;
               System.Console.WriteLine(ex.Message);
           }
          
           mc.Dispose();
           return rval >= 0 && rval != null ? rval + 1 : null;
       }
        /// <summary>
        /// Gets the user names into a array with the format {FirstName Lastname}
        /// </summary>
        /// <param name="ACTIVE_LOGIN">Filter for only active logins?</param>
        /// <returns>An array of names</returns>
       public string[] getUsersNC(bool ACTIVE_LOGIN=false){
           string alwhere = ACTIVE_LOGIN ? "WHERE VolunteerID IN (SELECT DISTINCT VolunteerID FROM Checkin WHERE Active=1 AND DATE(TimeIn)=DATE(NOW()))" : "";
            MySQLCommand mc = new MySQLCommand(String.Format("SELECT CONCAT(FirstName,\" \",LastName) FROM Volunteer {0};",alwhere), vlcon);//add where if ACTIVE_LOGIN
            MySQLDataReader dr;
            try { dr = mc.ExecuteReaderEx(); }
            catch (MySQLException) { throw new DatabaseNotOpenException(); }
            List<string> rval = new List<string>();//data string list
            int cnt=0;
            try{
                while (dr.Read())
                    rval.Insert(cnt++,dr.GetString(0));
            }finally{
                dr.Close();
                mc.Dispose();
            }
            string[] rval2=new string[rval.Count];
            rval.CopyTo(rval2);
            return rval2;
        }

        /// <summary>
        /// Gets the names of users in a format. @deprecated use getUsersNC()
        /// </summary>
        /// <param name="format">The user_output_type format for the output</param>
        /// <returns>A 2 dimensional array of strings, unstable!!</returns>
       public string[] getUsers(user_output_type format = user_output_type.FIRST_LAST)
       {
           string[] NAME_FORMAT_FILTER = { "VolunteerID", "CONCAT(FirstName,\" \",LastName)", "CONCAT(LastName,\", \",FirstName)", "CONCAT(FirstName,\" \",LastName),VolunteerID", "CONCAT(LastName,\", \",FirstName),VolunteerID" };
           System.Data.DataTable dt = new MySQLSelectCommand(
           vlcon,
           new string[] { NAME_FORMAT_FILTER[(int)user_output_type.FIRST_LAST] },
           new string[] { "Volunteer" },
           new object[,] { { } },
           null,
           null).Table;

           string[] rval = null;

           for (int i = 1; i <= dt.Rows.Count; i++)
           {
               rval[i] = dt.Rows[i][0].ToString();
           }
           return rval;
       }
       /// <summary>
       /// Gets the volunteer id from a name
       /// </summary>
       /// <param name="FIRST_NAME">The first name</param>
       /// <param name="LAST_NAME">The last name</param>
       /// <returns>A volunteer id or null if not found</returns>
      public uint? getVolunteerIDFromName(string FIRST_NAME, string LAST_NAME){
          MySQLCommand mc = new MySQLCommand(String.Format("SELECT VolunteerID FROM Volunteer WHERE FirstName ='{0}' AND LastName='{1}' LIMIT 1;", FIRST_NAME, LAST_NAME), vlcon);

          object qres;
          try { qres = mc.ExecuteScalar(); }
          catch (MySQLException) { throw new DatabaseNotOpenException(); }
          mc.Dispose();
          if (qres == null)
          {
              return null;
          }
          else
          {
              return uint.Parse(qres.ToString());
          }

      }
       /// <summary>
       /// Gets a volunteer id from a concatenated full name string
       /// </summary>
       /// <param name="FULL_NAME">The full name of the users in the format{FirstName LastName}</param>
       /// <returns>A volunteerID or null</returns>
      public uint? getVolunteerIDFromName(string FULL_NAME){
          MySQLCommand mc = new MySQLCommand(String.Format("SELECT VolunteerID FROM Volunteer WHERE CONCAT(FirstName,\" \",LastName)='{0}'  LIMIT 1;", FULL_NAME), vlcon);

          object qres;
          try { qres = mc.ExecuteScalar(); }
          catch (MySQLException) { throw new DatabaseNotOpenException(); }
            mc.Dispose();
          if(qres==null){
            return null;
          }else{
            return uint.Parse(qres.ToString());
          }

      }
        /// <summary>
        /// Get the volunteer id from name. @deprecated Uses unstable algorithms
        /// </summary>
        /// <param name="FirstName">The first name</param>
        /// <param name="LastName">The last name</param>
        /// <returns>A volunteer id</returns>
      public int? getVolunteerIDFromName_old(string FirstName,string LastName) {
          MySQLCommand mc = new MySQLCommand(String.Format("SELECT VolunteerID FROM Volunteer WHERE FirstName='{0}' AND LastName='{1}' LIMIT 1;", FirstName, LastName), vlcon);
          int? rval;
          try
          {
              object obj = mc.ExecuteScalar();
              rval = (int)mc.ExecuteScalar();
          }
          catch (Exception)
          {
             System.Console.WriteLine(mc.ExecuteScalar());
             rval= null;
          }
            mc.Dispose();
            return rval;
      }
       /// <summary>
       /// Gets the data from the last active checkin today and puts it into a SCheckin struct
       /// </summary>
       /// <param name="VolunteerID">The volunteer id to search for</param>
       /// <returns>A SCheckin or null if there is no current checkin</returns>
      public SCheckin? getLastActiveTimestamp(uint VolunteerID)
      {
          
          //Build Query
          string qry = String.Format("SELECT CheckID,VolunteerID,CONCAT(DATE(TimeIn),\" \", TIME(TimeIn)),Active FROM Checkin WHERE VolunteerID={0} AND Active=1 AND DATE(TimeIn)=DATE(NOW()) ORDER BY CheckID DESC LIMIT 1;", VolunteerID);
         
          //Query Data
          MySQLCommand mc = new MySQLCommand(qry, vlcon);

          MySQLDataReader dr = mc.ExecuteReaderEx();

          try { dr = mc.ExecuteReaderEx(); }
          catch (MySQLException) { throw new DatabaseNotOpenException(); }

          SCheckin rval = new SCheckin();
          //int cnt = 0;
          try
          {
              if (dr.HasRows == false) return null;
              while (dr.Read()) {
                 rval.CheckID=uint.Parse(dr.GetString(0));
                 rval.VolunteerID = uint.Parse(dr.GetString(1));
                 rval.TimeIn = dr.GetString(2); 
                  
                  System.Console.WriteLine(rval.TimeIn);
                 
                  rval.Active = dr.GetString(3)=="1"?true:false;
              }     
          }
          finally
          {
              dr.Close();
              mc.Dispose();
          }
          
          return rval;
      }
   /// <summary>
   /// Gets the volunteer timestamps to an array.@deprecated Use getLastActiveTimestamp. unstable!!
   /// </summary>
   /// <param name="VolunteerID"></param>
   /// <param name="ACTIVE_ONLY"></param>
   /// <param name="ONLY_TODAY"></param>
   /// <returns>A 2 dimension array of timestamps or an empty array</returns>
       public object [][] getVolunteerTimestamps(uint VolunteerID,Boolean ACTIVE_ONLY=false,Boolean ONLY_TODAY=true){
        //Build Query
		string qry="SELECT * FROM Checkin WHERE VolunteerID="+VolunteerID;
		if(ACTIVE_ONLY==true)
			qry+=" AND Active=1";
		if(ONLY_TODAY==true)
			qry+=" AND DATE(TimeIn)=DATE(NOW())";
		qry+=" ORDER BY CheckID DESC;";
        //Query Data
         MySQLCommand mc = new MySQLCommand(qry, vlcon);
         MySQLDataReader dr = mc.ExecuteReaderEx();

         List<object>[] rval = { new List<object>(), new List<object>(), new List<object>(), new List<object>()};//data string list
         int cnt=0;
         try{
             while (dr.Read())
             {
                 for (byte curfield = 0; curfield < rval.Length; curfield++)
                 {
                     rval[curfield].Insert(cnt, dr.GetString(curfield));
                     Console.WriteLine(rval.GetValue(curfield).ToString());
                 }
                 cnt++;
             }
            }finally{
                dr.Close();
                mc.Dispose();
            }
            return new object[][]{rval[0].ToArray(),rval[1].ToArray(),rval[2].ToArray(),rval[3].ToArray()};
        }
       /// <summary>
       /// Gets the TaskID of a task if it exists
       /// </summary>
       /// <param name="Task">The STask object containing the individual task data</param>
       /// <returns>The TaskID or null if the task doesn't exist. A new task can then be made with that STask</returns>
       private int? getExistingTaskID(STask Task){
           MySQLCommand mc = new MySQLCommand(
               String.Format(
             "SELECT TaskID FROM VolunteerTask WHERE {0}={1} AND {2}={3} AND {4}={5} AND {6}={7} AND {8}={9} AND {10}={11} AND {12}={13} AND {14}={15} AND {16}={17} AND {18}={19} AND {20}='{21}' LIMIT 1;"
            ,"Class",Task.Did_Class,"Office",Task.Office_Work,"Maintenance",Task.Maintenance,"Conditioning",Task.Conditioning,"HorseCare",Task.Horse_Care,"Committee",Task.Committee
            ,"Board",Task.Board,"JrVolunteer",Task.Jr_Volunteer,"SpecialOlympics",Task.Special_Olympics,"Other",Task.Other,"OtherDescription",filterEscape(Task.OtherDesc)
                ), vlcon);
           MySQLDataReader dr;
           try
           {
              dr = mc.ExecuteReaderEx();
           }
           catch (MySQLException) {
               throw new DatabaseNotOpenException();
           }
           int? rval=null;
           if (dr.Read()) {
               rval = dr.GetInt32(0);
           }
            mc.Dispose();
            dr.Dispose();
            return rval;
       }

       #endregion
       #region Insert
       /**********************************************************
     * 
     *              Insert Functions
     * 
     * ***********************************************************/
      
    /// <summary>
    /// Insert a user into the database
    /// </summary>
    /// <param name="FirstName">The first name</param>
    /// <param name="LastName">The last name</param>
    /// <returns>Success of the transaction</returns>
    public Boolean insertUser(string FirstName,string LastName){
        try
        {
            return new MySQLCommand(
                String.Format("INSERT INTO Volunteer (VolunteerID,FirstName,LastName)VALUES({0},'{1}','{2}');",
                getNewKey("Volunteer", "VolunteerID"), FirstName, LastName), vlcon)
                .ExecuteNonQuery() == 1;
        }
        catch (MySQLException) { throw new DatabaseNotOpenException(); }
    }
    /// <summary>
    /// Insert a manual VolunteerLog entry, linking the task and volunteer
    /// </summary>
    /// <param name="VolunteerID">The VolunteerID</param>
    /// <param name="TaskID">The TaskID of the referenced task, one task may belong to many logs</param>
    /// <param name="Date">The date of the log</param>
    /// <param name="TimeIn">The time in of the log</param>
    /// <param name="TimeOut">The time out of the log</param>
    /// <param name="Comment">An optional comment, filtered for xss/sql injection</param>
    /// <returns>Success of the transaction</returns>
    public Boolean insertLog(uint VolunteerID,uint TaskID,DateTime Date,myTime TimeIn,myTime TimeOut,string Comment){
        
        if (Comment.Length > TEXT_FIELD_MAX) throw new TextTooLargeException(String.Format("The Comment is too large({0}) max {1}!", Comment.Length, TEXT_FIELD_MAX));
        try
        {
            return new MySQLCommand(
                String.Format("INSERT INTO VolunteerLog(LogID,VolunteerID,TaskID,Date,TimeIn,TimeOut,Comment) VALUES({0},{1},{2},'{3}','{4}','{5}','{6}');",
                getNewKey("VolunteerLog", "LogID"), VolunteerID, TaskID, MySQLSafeDate(Date), TimeIn.toString(), TimeOut.toString(), filterEscape(Comment)), vlcon)
                .ExecuteNonQuery() == 1;
        }
        catch (MySQLException) { throw new DatabaseNotOpenException(); }
    }
    /// <summary>
    /// Insert a task forcibly(not with STask). ##Note: Does not return TaskID##
    /// </summary>
    /// <param name="Did_Class">Class</param>
    /// <param name="Office_Work">Office</param>
    /// <param name="Maintenance">Maintenance</param>
    /// <param name="Conditioning">Conditioning</param>
    /// <param name="Horse_Care">Horse Care</param>
    /// <param name="Committee">Committee</param>
    /// <param name="Board">Board</param>
    /// <param name="Jr_Volunteer">Jr Volunteer</param>
    /// <param name="Special_Olympics">Special Olympics</param>
    /// <param name="Other">Other</param>
    /// <param name="OtherDesc">Other description, filtered for xss/sql injection</param>
    /// <returns>Success of the transaction</returns>
    public Boolean insertTaskForce(
        Boolean Did_Class, Boolean Office_Work, Boolean Maintenance, Boolean Conditioning,
        Boolean Horse_Care, Boolean Committee, Boolean Board, Boolean Jr_Volunteer,Boolean Special_Olympics, Boolean Other,string OtherDesc)
    {
        
        int? key=getNewKey("VolunteerTask", "TaskID");

        if (key == null) return false;
        try
        {
            return new MySQLCommand(
                String.Format("INSERT INTO VolunteerTask VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},'{11}');",
                key, Did_Class, Office_Work, Maintenance, Conditioning,
                Horse_Care, Committee, Board, Jr_Volunteer, Special_Olympics, Other, filterEscape(OtherDesc)), vlcon)
                .ExecuteNonQuery() == 1;
        }
        catch (MySQLException) { throw new DatabaseNotOpenException(); }
    }
    /// <summary>
    /// Insert a task using STask to house the data
    /// </summary>
    /// <param name="Task">A STask collection of task data</param>
    /// <returns>The resulting task id or null on failure, checks for existing item first</returns>
    public uint? insertTask(STask Task)
    {
        if (Task.OtherDesc.Length > TEXT_FIELD_MAX) throw new TextTooLargeException(String.Format("OtherDescription is too large({0}) max {1}!", Task.OtherDesc.Length, TEXT_FIELD_MAX));

        uint? key = (uint?)getExistingTaskID(Task);//Check for task, get index or 

        if (key == null)
        {
            key = (uint?)getNewKey("VolunteerTask", "TaskID");
            try
            {
                return new MySQLCommand(
                    String.Format("INSERT INTO VolunteerTask VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},'{11}');",
                    key, Task.Did_Class, Task.Office_Work, Task.Maintenance, Task.Conditioning,
                    Task.Horse_Care, Task.Committee, Task.Board, Task.Jr_Volunteer, Task.Special_Olympics, Task.Other, filterEscape(Task.OtherDesc)), vlcon)
                    .ExecuteNonQuery() == 1 ? key : null;
            }
            catch (MySQLException) { throw new DatabaseNotOpenException(); }
        }
        else return key;
    }
    /// <summary>
    /// Insert a Checkin timestamp to the database
    /// </summary>
    /// <param name="VolunteerID">Who has signed in</param>
    /// <returns>Success of the transaction</returns>
    public Boolean insertCheckin(uint VolunteerID){
        try
        {
            return new MySQLCommand(
                String.Format("INSERT INTO CheckIn(CheckID,VolunteerID) VALUES({0},{1})",
                getNewKey("CheckIn", "CheckID"), VolunteerID), vlcon)
                .ExecuteNonQuery() == 1;
        }
        catch (MySQLException) { throw new DatabaseNotOpenException(); }
    }
    /// <summary>
    /// Inserts a volunteer log using a timestamp as the basis(logout)
    /// </summary>
    /// <param name="VolunteerID">The id of the volunteer</param>
    /// <param name="TaskID">The TaskID of the task to be linked</param>
    /// <returns>Success of the transaction</returns>
    public Boolean insertVolunteerLogFromTimestamp(uint VolunteerID,uint TaskID) {
    
         SCheckin? LAST_CHECKIN = getLastActiveTimestamp(VolunteerID);

         if (LAST_CHECKIN == null) throw new NoCheckinException("There is no active checkin for user " + VolunteerID + "!");
         try
         {
             return new MySQLCommand(
              String.Format("INSERT INTO VolunteerLog(LogID,VolunteerID,TaskID,Date,TimeIn,TimeOut,Comment)VALUES({0},{1},{2},DATE('{3}'),TIME('{3}'),TIME(CURTIME()),'{4}');"
              , getNewKey("VolunteerLog", "LogID"), VolunteerID, TaskID, LAST_CHECKIN.Value.TimeIn, "Generated via Timestamp"
              ), vlcon).ExecuteNonQuery() == 1 && deleteCheckin(LAST_CHECKIN.Value.CheckID);
         }
         catch (MySQLException) { throw new DatabaseNotOpenException(); }
    }
       #endregion
       #region Delete

    /// <summary>
    /// Delete a checkin(timestamp) Used for after the timestamp has been spent
    /// </summary>
    /// <param name="CheckID">The ID of the timestamp</param>
    /// <returns>Success of the transaction, will "SELECT * FROM CheckIn WHERE CheckID=[CheckID]" return no value?</returns>
    private Boolean deleteCheckin(uint CheckID){
        try
        {
            return new MySQLCommand(
                String.Format("DELETE FROM CheckIn WHERE CheckID={0};",
               CheckID), vlcon)
                .ExecuteNonQuery() == 1;
        }
        catch (MySQLException) { throw new DatabaseNotOpenException(); }
    }

        #endregion
        #region Admin
        /// <summary>
        /// Gets the user details.
        /// </summary>
        /// <param name="selectedIndex">The Order By index.</param>
        /// <param name="ascending">True if sort is ascending.</param>
        /// <returns>A String[5] with the results</returns>
        public List<String[]> getUserAdminTable(int selectedIndex, bool ascending)
        {
            String sql = "SELECT v.VolunteerID,v.LastName,v.FirstName,MAX(vl.Date) AS \"LastActivity\",SUM(vl.TotalHours) as \"SumHours\",COUNT(vl.LogID) as \"NumLogs\" FROM Volunteer v LEFT OUTER JOIN volunteerlog vl on v.VolunteerID=vl.VolunteerID GROUP BY v.VolunteerID {0};";
            MySQLCommand mc = new MySQLCommand(
                String.Format(sql,getUserOrderBy(selectedIndex, ascending))
             , vlcon);
            MySQLDataReader dr;
            try
            {
                dr = mc.ExecuteReaderEx();
            }
            catch (MySQLException ex)
            {
                mc.Dispose();
                throw;
            }
            mc.Dispose();
            List<String[]> rval = new List<string[]>();
            while (dr.Read())
            {
                String[] result = new String[5];
                result[0] = dr[0].ToString();
                result[1] = dr[1].ToString();
                result[2] = dr[2].ToString();
                result[3] = dr[3].ToString();
                result[4] = String.Concat(dr[4],"/",dr[5]);
                rval.Add(result);
            }
            // Clean up
            dr.Close();
            dr.Dispose();
            return rval;
        }
        /// <summary>
        /// Gets the order by for the user lookup.
        /// </summary>
        /// <param name="selectedIndex">The Order By index.</param>
        /// <param name="ascending">True if sort is ascending.</param>
        /// <returns>The orderby portion of the query.</returns>
        private String getUserOrderBy(int selectedIndex, bool ascending)
        {
            switch (selectedIndex)
            {
                case 0:
                    return "ORDER BY VolunteerID " + (ascending == true ? "ASC" : "DESC"); ;
                case 1:
                    return "ORDER BY FirstName " + (ascending == true ? "ASC" : "DESC");
                case 2:
                    return "ORDER BY LastName " + (ascending == true ? "ASC" : "DESC");
                case 3:
                    return "ORDER BY LastActivity " + (ascending == true ? "ASC" : "DESC");
                case 4:
                    return "ORDER BY SumHours " + (ascending == true ? "ASC" : "DESC");
                case 5:
                    return "ORDER BY NumLogs " + (ascending == true ? "ASC" : "DESC");
                default:
                    return String.Empty;
            }
        }

        /// <summary>
        /// Gets a list of Usernames concatenated with the user ids.
        /// </summary>
        /// <returns>A dictionary where the key is the ID and the name is the value.</returns>
        public Dictionary<int, String> getUsersList()
        {
            String sql = "SELECT VolunteerID,CONCAT(FirstName,' ',LastName) FROM Volunteer";
            MySQLCommand mc = new MySQLCommand(sql, vlcon);
            MySQLDataReader dr;
            try
            {
                dr = mc.ExecuteReaderEx();
            }
            catch (MySQLException)
            {
                mc.Dispose();
                throw;
            }
            mc.Dispose();
            Dictionary<int, String> rval = new Dictionary<int, String>();
            while (dr.Read())
            {
                try
                {
                    rval.Add(dr.GetInt32(0), dr.GetString(1));
                }
                catch (Exception ex) {
                    Console.Out.WriteLine(ex.Message);
                }
            }
            dr.Dispose();
            return rval;
        }
        /// <summary>
        /// Edits a user's Firstname/Lastname.
        /// </summary>
        /// <param name="volunteerID">The volunteer id</param>
        /// <param name="firstName">The new First Name</param>
        /// <param name="lastName">The new Last Name</param>
        /// <returns>The result of the query.</returns>
        public int editUser(int volunteerID, String firstName, String lastName) {
            String sql = "UPDATE Volunteer SET FirstName = \"{1}\", LastName = \"{2}\" WHERE VolunteerID = {0};";
            MySQLCommand mc = new MySQLCommand(String.Format(sql, volunteerID, filterEscape(firstName), filterEscape(lastName)), vlcon);
            // Execute and store the result
            int result = mc.ExecuteNonQuery();
            mc.Dispose();
            return result;
        }
        /// <summary>
        /// Deletes the user from the Volunteer
        /// </summary>
        /// <param name="volunteerID">The ID of the volunteer to delete</param>
        /// <returns>The result of the query.</returns>
        public int deleteUser(int volunteerID)
        {
            String sql = "DELETE FROM Volunteer WHERE VolunteerID = {0};";
            MySQLCommand mc = new MySQLCommand(String.Format(sql, volunteerID), vlcon);
            // Execute and store the result
            int result = mc.ExecuteNonQuery();
            mc.Dispose();
            return result;
        }
        /// <summary>
        /// Gets a Dictionary of VolunteerIDs and names for volunteers with any checkins.
        /// </summary>
        ///<exception cref="MySQLException">There was an exception in the database call.</exception>
        /// <returns>A dictionary </returns>
        public Dictionary<int,String> getVolunteersWithCheckins()
        {
            string sql = "SELECT VolunteerID, CONCAT(FirstName,\" \",LastName) FROM Volunteer WHERE VolunteerID IN (SELECT DISTINCT VolunteerID FROM Checkin WHERE Active=1)";
            MySQLCommand mc = new MySQLCommand(sql, vlcon);//add where if ACTIVE_LOGIN
            MySQLDataReader dr;
            dr = mc.ExecuteReaderEx();
            Dictionary<int, String> rval = new Dictionary<int, String>();
            while (dr.Read())// Populate the list of volunteers and ids
                rval.Add(dr.GetInt32(0), dr.GetString(1));
            //Close and dispose
            dr.Close();
            mc.Dispose();
            return rval;
        }
        /// <summary>
        /// Gets the CheckID and TimeIn values from Checkin per volunteer
        /// </summary>
        /// <param name="volunteerID"></param>
        /// <returns></returns>
        public Dictionary<int,DateTime> getCheckinsList(int volunteerID)
        {
            String sql = "SELECT CheckID, TimeIn FROM Checkin WHERE VolunteerID={0} AND Active=1 ORDER BY CheckID DESC;";
            MySQLCommand mc = new MySQLCommand(String.Format(sql, volunteerID), vlcon);//add where if ACTIVE_LOGIN
            MySQLDataReader dr;
            dr = mc.ExecuteReaderEx();
            Dictionary<int, DateTime> rval = new Dictionary<int, DateTime>();
            while (dr.Read())// Populate the list of volunteers and ids
                rval.Add(dr.GetInt32(0), DateTime.Parse(dr.GetString(1)));
            //Close and dispose
            dr.Close();
            mc.Dispose();
            return rval;
        }
        /// <summary>
        /// Deletes a checkin by ID.
        /// </summary>
        /// <param name="checkID">The identifier of the checkin to delete.</param>
        /// <returns>Result of Execution.</returns>
        public int deleteCheckin(int checkID)
        {
            String sql = "DELETE FROM Checkin WHERE CheckID = {0};";
            MySQLCommand mc = new MySQLCommand(String.Format(sql, checkID), vlcon);
            // Execute and store the result
            int result = mc.ExecuteNonQuery();
            mc.Dispose();
            return result;
        }

        bool tsBatch(string action,string filter) {
        string qry="";
        switch(action){
		case "activate":
			qry="UPDATE checkin SET Active=1";
			break;
		case "deactivate":
			qry="UPDATE checkin SET Active=0";
			break;
		case "delete":case "purge":
			qry="DELETE FROM checkin";
			break;
		default:
			return false;
	}//end switch
	//append filter
	switch(filter){
		case "all":
			//do nothing
			break;
		case "old":
			qry +=" WHERE DATE(timein)<DATE(NOW())";
			break;
		case "today":
			qry +=" WHERE DATE(timein)=DATE(NOW())";
			break;
		case "inactive":
			qry +=" WHERE Active=0";
			break;
		case "active":
			qry +=" WHERE Active=1";
			break;
	}//end switch filter
    return new MySQLCommand(qry, vlcon).ExecuteNonQuery()==1;
    }//end function

    bool mutils(string action)
    {
        string qry;
        switch (action)
        {
            case "rtask":
                qry = "DELETE FROM VolunteerTask WHERE TaskID NOT IN(SELECT DISTINCT TaskID FROM volunteerlog);";
                break;
            case "topt":
                qry = "OPTIMIZE TABLE checkin,volunteer,volunteerlog,volunteertask;";
                break;
            case "trep":
                qry = "REPAIR TABLE checkin,volunteer,volunteerlog,volunteertask;";
                break;
            case "excache":
            default:
                return false;
        }//end switch
        return new MySQLCommand(qry, vlcon).ExecuteNonQuery() == 1;
    }//end function

    public Boolean deleteRecord(string table,string ID_Field,uint ID)
    {
        try
        {
            return new MySQLCommand(
                String.Format("DELETE FROM {0} WHERE {1}={2};",
               table,ID_Field,ID), vlcon)
                .ExecuteNonQuery() == 1;
        }
        catch (MySQLException) { throw new DatabaseNotOpenException(); }
    }

    public string[] query1d_string(string query)
    {
        
        MySQLCommand mc = new MySQLCommand(query, vlcon);//add where if ACTIVE_LOGIN
        MySQLDataReader dr;
        try { dr = mc.ExecuteReaderEx(); }
        catch (MySQLException) { throw new DatabaseNotOpenException(); }
        List<string> rval = new List<string>();//data string list
        try
        {
            while (dr.Read())
                rval.Add(dr.GetString(0));
        }
        finally
        {
            dr.Close();
            mc.Dispose();
        }
        string[] rval2 = new string[rval.Count];
        rval.CopyTo(rval2);
        return rval2;
    }


    public object[][] query2d(string query)
    {
        //Query Data
        MySQLCommand mc = new MySQLCommand(query, vlcon);
        MySQLDataReader dr=null;
        try
        {
            dr = mc.ExecuteReaderEx();
        }
        catch (FormatException f)
        {
            Console.WriteLine(f.Message + "|" + mc.Parameters.Count);
            return null;
        }
        finally {
            mc.Dispose();
        }
        
        object[][] rv=new object[dr.RecordsAffected] [];
        try
        {
            for(uint i=0;dr.Read()&&dr.HasRows;i++) 
            {
               
               rv[i] = new object[dr.FieldCount];
                
               dr.GetValues(rv[i]);
            }
        }
        finally
        {
            dr.Close();
            mc.Dispose();
        }
        return rv;
    }


     #endregion
    }//end class
}//end namespace