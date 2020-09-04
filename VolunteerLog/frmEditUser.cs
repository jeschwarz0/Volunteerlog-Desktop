using MySQLDriverCS;
using System;
using System.Windows.Forms;

namespace VolunteerLog
{
    public partial class frmEditUser : Form
    {
        private static bool ALLOW_DUPLICATE_VOLUNTEERS = false;
        private int _userID;

        public frmEditUser(int userID, String fullName)
        {
            InitializeComponent();
            // Store the user id for later use
            _userID = userID;
            // Preset values of text boxes
            String[] value = fullName.Split(' ');
            if (value.Length >= 2) {
                txtFN.Text = value[0];
                txtLN.Text = value[1];
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Checks for volunteer duplicates, does the user exist already?
        /// </summary>
        /// <returns>The duplicate status</returns>
        private bool volunteerDuplicateCheck()
        {
            try
            {
                return !(
                       ALLOW_DUPLICATE_VOLUNTEERS == false &&
                       Program.vc.getVolunteerIDFromName(txtFN.Text.Trim(), txtLN.Text.Trim()).HasValue
                       );
            }
            catch (DatabaseNotOpenException)
            {
                Program.forceQuit();
                return true;//for debugger
            }
        }

        private void cmdDone_Click(object sender, EventArgs e)
        {
            //Username empty check
            if (txtFN.Text == "" || txtLN.Text == "")
            {
                MessageBox.Show("The username can't be empty!", "Empty User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (volunteerDuplicateCheck())
            {//username duplicate check
                try
                {
                    Program.vc.editUser(_userID, txtFN.Text.Trim(), txtLN.Text.Trim());//do the insert
                }
                catch (MySQLException ex)
                {
                    frmAdmin.ShowMySQLException(ex);
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
    }
}
