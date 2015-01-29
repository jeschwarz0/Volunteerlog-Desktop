using System;
using System.Collections.Generic;
using System.Windows.Forms;
using libVL;
namespace VolunteerLog
{
    /// <summary>
    /// A GUI for the VolunteerLog database, dedicated to North Country R.I.D.E.
    /// </summary>
    static class Program
    {

        public static libVL.VLDBCon vc;//The database connection used for all items

        public static uint? current_taskid = null;//transferable taskid

        public static bool? manual_path = null;//are you logging out manual, timestamp or null(none)?

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try { vc = new VLDBCon(); }
            catch (DatabaseNotOpenException) {
                //No point in doing anything if database connection fails//
                MessageBox.Show("The database is turned off!\n Run \"services.msc\" and start \"MySQL\"!", "No Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.Run(new frmMenu());//start main form
            vc.close();//close database
        }
       /// <summary>
       /// Close the database connection, show a message and quit this application.
       /// Run this only on a DatabaseNotOpenException
       /// </summary>
        public static void forceQuit(){
            vc.close();
            MessageBox.Show("The system has to be shut down, there was a problem!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            System.Environment.Exit(1);//close this application
        }
    }
}
