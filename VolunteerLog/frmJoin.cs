using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VolunteerLog
{
    public partial class frmJoin : Form
    {
        private static bool ALLOW_DUPLICATE_VOLUNTEERS = false;

        public frmJoin()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();//close this form
        }

        private void cmdDone_Click(object sender, EventArgs e)
        {
            //Username empty check
            if (txtFN.Text == "" || txtLN.Text == "") {
                MessageBox.Show("The username can't be empty!", "Empty User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (volunteerDuplicateCheck()){//username duplicate check
                try
                {
                    Program.vc.insertUser(txtFN.Text.Trim(), txtLN.Text.Trim());//do the insert
                }
                catch (TextTooLargeException ttle)
                {
                    MessageBox.Show(ttle.Message, "Text Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DatabaseNotOpenException)
                {
                    Program.forceQuit();
                }
                this.Close();
            }
            else
                MessageBox.Show(String.Format("The user {0} {1} already exists!", txtFN.Text.Trim(), txtLN.Text.Trim()), "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Checks for volunteer duplicates, does the user exist already?
        /// </summary>
        /// <returns>The duplicate status</returns>
        private bool volunteerDuplicateCheck() {
            try
            {
                return !(
                       ALLOW_DUPLICATE_VOLUNTEERS == false &&
                       Program.vc.getVolunteerIDFromName(txtFN.Text.Trim(), txtLN.Text.Trim()).HasValue
                       );
            }
            catch (DatabaseNotOpenException) {
                Program.forceQuit();
                return true;//for debugger
            }
        }
    }
}
