using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VolunteerLog
{
    public partial class frmLogout : Form
    {
        public frmLogout()
        {
            InitializeComponent();
        }

        private void frmLogout_Load(object sender, EventArgs e)
        {
            try
            {
                cboName.DataSource = Program.vc.getUsersNC(true);//Fill cboName with volunteers HAVING an active login
            }
            catch (DatabaseNotOpenException)
            {
                Program.forceQuit();
            }

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();//close this form
        }

        private void cmdDone_Click(object sender, EventArgs e)
        {
            uint? vid=null;//volunteerID null for compiler
            try
            {
                vid = Program.vc.getVolunteerIDFromName(cboName.Text);//get the volunteerID from the combo box
            }
            catch (DatabaseNotOpenException) { Program.forceQuit(); }

            if (vid != null && Program.current_taskid!=null)
            {
                try
                {
                    Program.vc.insertVolunteerLogFromTimestamp(vid.Value, Program.current_taskid.Value);// Do the transaction
                }
                catch (NoCheckinException nce)
                {
                    MessageBox.Show(nce.Message, "No Checkin", MessageBoxButtons.OK, MessageBoxIcon.Error);// If there is no checkin
                }
                catch (DatabaseNotOpenException) {
                    Program.forceQuit();
                }
                this.Close();
            }
        }



    }
}
