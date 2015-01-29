/// <summary>
/// A collection of task information, combined for portability
/// </summary>
public class STask
{
    public bool Did_Class,Office_Work,Maintenance,Conditioning,Horse_Care,Committee,Board,Jr_Volunteer,Special_Olympics,Other;

    public string OtherDesc;
    /// <summary>
    /// Create a new instance of STask
    /// </summary>
    /// <param name="Did_Class">bool</param>
    /// <param name="Office_Work">bool</param>
    /// <param name="Maintenance">bool</param>
    /// <param name="Conditioning">bool</param>
    /// <param name="Horse_Care">bool</param>
    /// <param name="Committee">bool</param>
    /// <param name="Board">bool</param>
    /// <param name="Jr_Volunteer">bool</param>
    /// <param name="Special_Olympics">bool</param>
    /// <param name="Other">bool</param>
    /// <param name="OtherDesc">string</param>
    public STask(
        bool Did_Class, bool Office_Work, bool Maintenance, bool Conditioning,
        bool Horse_Care, bool Committee, bool Board, bool Jr_Volunteer, bool Special_Olympics, bool Other, string OtherDesc) {

            this.Did_Class = Did_Class;
            this.Office_Work = Office_Work;
            this.Maintenance = Maintenance;
            this.Conditioning = Conditioning;
            this.Horse_Care = Horse_Care;
            this.Committee = Committee;
            this.Board = Board;
            this.Jr_Volunteer = Jr_Volunteer;
            this.Special_Olympics = Special_Olympics;
            this.Other = Other;
            this.OtherDesc = OtherDesc;
    }
}