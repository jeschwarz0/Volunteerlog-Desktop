using MySQLDriverCS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VolunteerLog
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lstSortBy.SelectedIndex = 0;
        }

        private void btnUsersSubmit_Click(object sender, EventArgs e)
        {
            List<String[]> results;
            try
            {   // Query results 
                results = Program.vc.getUserAdminTable(lstSortBy.SelectedIndex, chkAscending.Checked);
            }
            catch (MySQLException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid UserName/Password");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                        return;
            }
            //Clear existing items
            lvUsersOutput.Items.Clear();
            //Show lvUsersOutput
            if(lvUsersOutput.Visible == false)
                lvUsersOutput.Visible = true;
            foreach (String[] result in results)
            {
                String[] row = new String[4];
                Console.WriteLine(result[0]);
                row[0] = result[1];
                row[1] = result[2];
                // Parse out date string if provided
                if (!String.IsNullOrEmpty(result[3]))
                {
                    DateTime lastLogin = DateTime.Parse(result[3]);
                    row[2] = lastLogin.ToShortDateString();
                }
                else { row[2] = "None"; }
                // Set numlogs to None if empty if                
                row[3] = result[4].Equals("/0") ? "None" : result[4];
                lvUsersOutput.Items.Add(new ListViewItem(row));
            }
        }
    }
}
