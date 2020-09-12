using libVL;
using MySQLDriverCS;
using System;
using System.Windows.Forms;

namespace VolunteerLog
{
    public partial class frmEditCheckin : Form
    {
        public frmEditCheckin(int checkID)
        {
            InitializeComponent();
            // Assign checkid
            _checkid = checkID;
            CheckinRec crec;
            try
            {// Get the checkin details
                crec = Program.vc.getCheckinDetail(checkID);
                txtTimeIn.Text = crec.TimeIn;
                chkIsActive.Checked = crec.IsActive;
            }
            catch (MySQLException ex)
            {
                frmAdmin.ShowMySQLException(ex);
                // Close with aborted dialog result
                DialogResult = DialogResult.Abort;
                Close();
            }
        }
        /// <summary>
        /// The global CheckID
        /// </summary>
        private int _checkid;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime temp;
            // Try to parse the new Time in text
            if (DateTime.TryParse(txtTimeIn.Text, out temp))
            {
                try
                {// Edit the MySQL formatted datetime
                    Program.vc.editCheckin(_checkid, temp.ToString("yyyy-MM-dd HH:mm:ss"), chkIsActive.Checked);
                    Close();
                }
                catch (MySQLException ex)
                {
                    frmAdmin.ShowMySQLException(ex);
                    // Set dialog result to abort
                    DialogResult = DialogResult.Abort;
                }
            }
        }
    }
}
