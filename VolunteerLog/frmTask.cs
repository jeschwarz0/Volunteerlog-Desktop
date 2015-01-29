using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VolunteerLog
{
    public partial class frmTask : Form
    {
        public frmTask()
        {
            InitializeComponent();
        }

        private void frmTask_Load(object sender, EventArgs e)
        {
            Program.current_taskid = null;//clear current taskid
        }
        /// <summary>
        /// Gets a STask object from inputs on this form
        /// </summary>
        /// <returns>A STask object corresponding to this form</returns>
        STask toSTask() {
            return new STask(
                chkClass.Checked, chkOffice.Checked, chkMaintenance.Checked, chkConditioning.Checked
                , chkHorseCare.Checked, chkCommittee.Checked, chkBoard.Checked, chkJrVolunteer.Checked
                , chkSpecialOlympics.Checked, chkOther.Checked, txtOtherDesc.Text);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {//blank state data
            Program.manual_path = null;
            Program.current_taskid = null;
            this.Close();//close
        }

        private void cmdDone_Click(object sender, EventArgs e)
        {
            try { Program.current_taskid = Program.vc.insertTask(toSTask()); }//do the task insert, set global TaskID for later use
            catch (DatabaseNotOpenException) {//forcequit if database is not open
                Program.forceQuit(); 
            }

            if (Program.current_taskid != null && Program.manual_path!=null)//validity check
            {
                // Act based on bias, show Manual or Logout
                switch (Program.manual_path) { 
                    case true:
                        //show frmManual
                        this.Hide();
                        new frmManual().ShowDialog(this.ParentForm);
                        this.Close();
                        break;
                    case false:
                        //show frmLogout
                        this.Hide();
                        new frmLogout().ShowDialog(this.ParentForm);
                        this.Close();
                        break;
                }

            }
            else cmdCancel_Click(null,null);//initiate cancel
        }

        private void chkOther_CheckedChanged(object sender, EventArgs e)
        {  //Blank and disable other description when other is off, enable when on.
            txtOtherDesc.Enabled = chkOther.Checked;
            if (chkOther.Checked == false) txtOtherDesc.Clear();
        }
      


    }
}
