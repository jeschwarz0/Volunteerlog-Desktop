/// <summary>
/// A time class for use with MySQL
/// </summary>
public class myTime {

    public byte hour;
    public byte minute;
    /// <summary>
    /// Creates a myTime with preset data 12 hour
    /// </summary>
    /// <param name="HOUR">The hours(1-12)</param>
    /// <param name="MINUTE">The minutes(0-59)</param>
    /// <param name="IsAM">Is it am?</param>
    public myTime(byte HOUR, byte MINUTE, bool IsAM) { 
        //hour
        if (HOUR == 12)
        {
            this.hour = IsAM == true ? (byte)24 : HOUR;
        }
        else if (IsAM == false)
        {
            this.hour = (byte)(HOUR + 12);
        }
        else this.hour = HOUR;
        //minute
        this.minute = MINUTE;
    }
    /// <summary>
    /// Generic creation of mytime at 12:60 pm
    /// </summary>
    public myTime() {
        hour = 12;
        minute = 60;
    }
    /// <summary>
    /// Gets a new myTime with the given values
    /// </summary>
    /// <param name="HOUR">The hours(1-12)</param>
    /// <param name="MINUTE">The minutes(0-59)</param>
    /// <param name="IsAM">Is it am?</param>
    /// <returns>A new myTime</returns>
  public static myTime valueOf(byte HOUR, byte MINUTE, bool IsAM) {
      return new myTime(HOUR, MINUTE, IsAM);
    }
    /// <summary>
    /// Checks if the time is valid
    /// </summary>
    /// <returns>Validity of the current instance</returns>
  public bool isValid() {
      return (hour > 0 && hour < 13) && (minute >= 0 && minute < 60);
  }
    /// <summary>
    /// Compare this to another myTime
    /// </summary>
    /// <param name="compareto">The myTime object to compare to</param>
    /// <returns>0 if times are equal, 1 if this is &gt; than compareto, or 2 if this is &lt; than compareto</returns>
  public byte compare(myTime compareto)
  {// 0 is == 1 is > 2 is <
      if (this.hour > compareto.hour)
      {
          return 1;
      }
      else if (this.hour < compareto.hour)
      {
          return 2;
      }
      else if (this.hour == compareto.hour)
      {
          if (this.minute == compareto.minute)
          {
              return 0;
          }
          else if (this.minute > compareto.minute)
          {
              return 1;
          }
          else
          {
              return 2;
          }
      }
      else return 0;
  }
    /// <summary>
    /// Returns a MySQL safe string of the time(hour and minute) 24 hour format
    /// </summary>
    /// <returns>A MySQL safe string of the time(hour and minute) 24 hour format</returns>
    public string toString(){
        return string.Format("{0}:{1}:00", hour, minute);
    }
}