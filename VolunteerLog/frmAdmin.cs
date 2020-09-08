﻿using MySQLDriverCS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VolunteerLog
{
    public partial class frmAdmin : Form
    {
        #region Init
        public frmAdmin()
        {
            InitializeComponent();
            initialializeUsersDD();
            initializeTimestampVolunteers();
        }
        /// <summary>
        /// The dictionary of user names to indexes.
        /// </summary>
        private Dictionary<int, String> _usersList;
        /// <summary>
        /// The dictionary of user names with checkins.
        /// </summary>
        private Dictionary<int, String> _timestampVolunteers;
        /// <summary>
        /// The dictionary of timestamps for the active user.
        /// </summary>
        private Dictionary<int, DateTime> _timestampValues;
        /// <summary>
        /// Initialize the users dropdown.
        /// </summary>
        private void initialializeUsersDD() {
            try
            {
                _usersList = Program.vc.getUsersList();
            } catch (MySQLException ex)
            {
                //Hide the Edit User tab
                tbEditUser.Hide();
                // Set an empty dictionary for safety
                _usersList = new Dictionary<int, string>();
                ShowMySQLException(ex);
                return;
            }
            // Clear combobox items
            cboUserSelect.Items.Clear();
            // Add the items to cboUsers
            foreach (KeyValuePair<int,String> item in _usersList)
            {
                cboUserSelect.Items.Add(item.Value);
            }
            // Disable edit and delete
            btnUserEdit.Enabled = false;
            btnUserDelete.Enabled = false;
        }
        /// <summary>
        /// Initialize the VolunteerList 
        /// </summary>
        private void initializeTimestampVolunteers() {
            try
            {
                _timestampVolunteers = Program.vc.getVolunteersWithCheckins();
            }
            catch (MySQLException ex)
            {
                ShowMySQLException(ex);
                _timestampVolunteers = new Dictionary<int, String>();
            }
                // Clear and add users to list
            cboTimestampVolunteers.Items.Clear();
            foreach (KeyValuePair<int,String> kvp in _timestampVolunteers) {
                cboTimestampVolunteers.Items.Add(kvp.Value);
            }// Set additional controls to invisible
            cboTimestampItems.Visible = btnTimestampDelete.Visible = btnTimestampEdit.Visible = false;
            cboTimestampItems.Items.Clear();
        }
        /// <summary>
        /// Shows a detailed messagebox on MySQL Exception.
        /// </summary>
        /// <param name="ex">The exception object.</param>
        internal static void ShowMySQLException(MySQLException ex)
        {
            switch (ex.Number)
            {
                case 0:
                    MessageBox.Show("Cannot connect to server", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1045:
                    MessageBox.Show("Invalid UserName/Password", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lstSortBy.SelectedIndex = 0;
        }
        #endregion
        #region Show Volunteers
        private void btnUsersSubmit_Click(object sender, EventArgs e)
        {
            List<String[]> results;
            try
            {   // Query results 
                results = Program.vc.getUserAdminTable(lstSortBy.SelectedIndex, chkAscending.Checked);
            }
            catch (MySQLException ex)
            {
                ShowMySQLException(ex);
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
        #endregion
        #region Edit Volunteer
        private void cboUserSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbSender = (ComboBox)sender;
            if (cbSender.SelectedIndex >= 0) {
                btnUserEdit.Enabled = true;
                btnUserDelete.Enabled = true;
            }
        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            if (cboUserSelect.SelectedItem == null)
                return;
            String selectedUser = cboUserSelect.SelectedItem.ToString();
            if (selectedUser != String.Empty)
            {
                foreach (KeyValuePair<int, String> kvp in _usersList)
                {
                    if (kvp.Value == selectedUser)
                    {
                        new frmEditUser(kvp.Key, kvp.Value).ShowDialog();
                        // Refresh the dropdown
                        initialializeUsersDD();
                    }
                }
            }
            
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (cboUserSelect.SelectedItem == null)
                return;
            String selectedUser = cboUserSelect.SelectedItem.ToString();
            if (selectedUser != String.Empty)
            {
               DialogResult promptResponse = MessageBox.Show("Are you sure you want to delete " + selectedUser + "?", "Confirm Deletion",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (promptResponse == DialogResult.OK)
                {
                    foreach (KeyValuePair<int, String> kvp in _usersList)
                    {
                        if (kvp.Value == selectedUser)
                        {
                            try
                            {
                                // Delete the user
                                Program.vc.deleteUser(kvp.Key);
                            }
                            catch (MySQLException ex) {
                                ShowMySQLException(ex);
                            }
                            initialializeUsersDD();
                        }
                    }
                }
            }
        }
        #endregion
        #region Timestamps
        private void cboTimestampVolunteers_SelectedIndexChanged(object sender, EventArgs e)
        {
            object volunteerSelected = ((ComboBox)sender).SelectedItem;
            if (volunteerSelected != null) {
                // Find the actively selected volunteerID
                int volunteerID = -1;
                foreach (KeyValuePair<int, String> kvp in _timestampVolunteers) {
                    if (kvp.Value == volunteerSelected.ToString())
                    {
                        volunteerID = kvp.Key;
                        break;
                    }
                }// Return if not found
                getTimestampItems(volunteerID);
                populatecboTimestampItems();
            }
        }

        private void getTimestampItems(int volunteerID) {
            // If volunteerID is not found, exit
            if (volunteerID == -1) {
                _timestampValues = new Dictionary<int, DateTime>();
                return;
            }
            try
            {
                _timestampValues = Program.vc.getCheckinsList(volunteerID);
            }
            catch (MySQLException ex)
            {
                ShowMySQLException(ex);
                _timestampValues = new Dictionary<int, DateTime>();
            }
        }

        private void populatecboTimestampItems() {
            // Show the top tier items list
            cboTimestampItems.Visible = true;
            // Empty the list first
            cboTimestampItems.Items.Clear();
            foreach (KeyValuePair<int, DateTime> kvp in _timestampValues) {
                cboTimestampItems.Items.Add(kvp.Value.ToString());
            }
        }
      
        private void cboTimestampItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedTS = ((ComboBox)sender).SelectedItem;
            // Show or hide Timestamp delete and edit buttons
            btnTimestampEdit.Visible = btnTimestampDelete.Visible = selectedTS != null;
        }
        #endregion
    }
}
