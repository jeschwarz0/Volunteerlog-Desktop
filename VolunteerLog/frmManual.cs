using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VolunteerLog
{
    public partial class frmManual : Form
    {
        public frmManual()
        {
            InitializeComponent();
        }

        private void frmManual_Load(object sender, EventArgs e)
        {
            try
            {
                cboName.DataSource = Program.vc.getUsersNC();//populate cboName with all the volunteers
            }
            catch (DatabaseNotOpenException) { Program.forceQuit(); }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Program.current_taskid = null;//clear the current task
            Program.manual_path = null;//clear the path state(manual)
            this.Close();//close this
        }

        private void cmdDone_Click(object sender, EventArgs e)
        {
            uint? vid;//volunteerid
            try { vid = Program.vc.getVolunteerIDFromName(cboName.Text); }//get the volunteer id
            catch (DatabaseNotOpenException) { Program.forceQuit(); return; }//Return is required for compiler

            myTime //set time objects
                timeIn = new myTime((byte)nudInHour.Value,  (byte)nudInMin.Value,  lblInTP.Text == "AM"), 
                timeOut= new myTime((byte)nudOutHour.Value, (byte)nudOutMin.Value, lblOutTP.Text == "AM");


            if(vid!=null&&Program.current_taskid!=null&&Program.manual_path==true){//check validity
                int tic=timeIn.compare(timeOut);//timeincompare
                if (tic == 0||tic==2)//Equal or less than
                {
                    try
                    {
                        if (!Program.vc.insertLog(vid.Value, Program.current_taskid.Value, dtpDate.Value, timeIn, timeOut, txtComment.Text)) {//insert log and warn if it doesn't work
                            MessageBox.Show("The transaction was not completed", "Warning");
                        }
                    }
                    catch (DatabaseNotOpenException) { Program.forceQuit(); }
                    cmdCancel_Click(null, null);//clear cache and exit
                }
                else {
                    MessageBox.Show("You left before you arrived?");
                }
            }
        }
        /// <summary>
        /// Toggle the AM/PM on a label
        /// </summary>
        /// <param name="control">The label to toggle the text</param>
        private static void toggleTP(Label control) { 
            //Toggle AM/PM on label
            switch (control.Text) { 
                case "AM":case "am":
                    control.Text = "PM";
                    break;
                case "PM":case "pm":
                    control.Text = "AM";
                    break;
            }
        }//end void

        private void lblInTP_Click(object sender, EventArgs e)
        {
            toggleTP(lblInTP);//toggle in
        }

        private void lblOutTP_Click(object sender, EventArgs e)
        {
            toggleTP(lblOutTP);//toggle out
        }//end void

    }
}