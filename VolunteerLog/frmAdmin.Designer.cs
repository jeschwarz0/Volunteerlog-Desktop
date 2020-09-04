namespace VolunteerLog
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbWelcome = new System.Windows.Forms.TabPage();
            this.tbUsers = new System.Windows.Forms.TabPage();
            this.lvUsersOutput = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUsersSubmit = new System.Windows.Forms.Button();
            this.chkAscending = new System.Windows.Forms.CheckBox();
            this.lstSortBy = new System.Windows.Forms.ListBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.tbEditUser = new System.Windows.Forms.TabPage();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserEdit = new System.Windows.Forms.Button();
            this.cboUserSelect = new System.Windows.Forms.ComboBox();
            this.tbTimestamp = new System.Windows.Forms.TabPage();
            this.tbReport = new System.Windows.Forms.TabPage();
            this.tbMaintenance = new System.Windows.Forms.TabPage();
            this.tbExport = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tbUsers.SuspendLayout();
            this.tbEditUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbWelcome);
            this.tabControl1.Controls.Add(this.tbUsers);
            this.tabControl1.Controls.Add(this.tbEditUser);
            this.tabControl1.Controls.Add(this.tbTimestamp);
            this.tabControl1.Controls.Add(this.tbReport);
            this.tabControl1.Controls.Add(this.tbMaintenance);
            this.tabControl1.Controls.Add(this.tbExport);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 463);
            this.tabControl1.TabIndex = 0;
            // 
            // tbWelcome
            // 
            this.tbWelcome.Location = new System.Drawing.Point(4, 22);
            this.tbWelcome.Name = "tbWelcome";
            this.tbWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tbWelcome.Size = new System.Drawing.Size(890, 437);
            this.tbWelcome.TabIndex = 0;
            this.tbWelcome.Text = "Welcome";
            this.tbWelcome.UseVisualStyleBackColor = true;
            // 
            // tbUsers
            // 
            this.tbUsers.Controls.Add(this.lvUsersOutput);
            this.tbUsers.Controls.Add(this.btnUsersSubmit);
            this.tbUsers.Controls.Add(this.chkAscending);
            this.tbUsers.Controls.Add(this.lstSortBy);
            this.tbUsers.Controls.Add(this.lblSortBy);
            this.tbUsers.Location = new System.Drawing.Point(4, 22);
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tbUsers.Size = new System.Drawing.Size(890, 437);
            this.tbUsers.TabIndex = 1;
            this.tbUsers.Text = "Users";
            this.tbUsers.UseVisualStyleBackColor = true;
            // 
            // lvUsersOutput
            // 
            this.lvUsersOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvUsersOutput.HideSelection = false;
            this.lvUsersOutput.Location = new System.Drawing.Point(189, 13);
            this.lvUsersOutput.Name = "lvUsersOutput";
            this.lvUsersOutput.Size = new System.Drawing.Size(680, 418);
            this.lvUsersOutput.TabIndex = 5;
            this.lvUsersOutput.UseCompatibleStateImageBehavior = false;
            this.lvUsersOutput.View = System.Windows.Forms.View.Details;
            this.lvUsersOutput.Visible = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "First Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Last Account Activity";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total Hours";
            // 
            // btnUsersSubmit
            // 
            this.btnUsersSubmit.Location = new System.Drawing.Point(108, 137);
            this.btnUsersSubmit.Name = "btnUsersSubmit";
            this.btnUsersSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnUsersSubmit.TabIndex = 4;
            this.btnUsersSubmit.Text = "Generate User List";
            this.btnUsersSubmit.UseVisualStyleBackColor = true;
            this.btnUsersSubmit.Click += new System.EventHandler(this.btnUsersSubmit_Click);
            // 
            // chkAscending
            // 
            this.chkAscending.AutoSize = true;
            this.chkAscending.Checked = true;
            this.chkAscending.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAscending.Location = new System.Drawing.Point(63, 114);
            this.chkAscending.Name = "chkAscending";
            this.chkAscending.Size = new System.Drawing.Size(76, 17);
            this.chkAscending.TabIndex = 3;
            this.chkAscending.Text = "Ascending";
            this.chkAscending.UseVisualStyleBackColor = true;
            // 
            // lstSortBy
            // 
            this.lstSortBy.FormattingEnabled = true;
            this.lstSortBy.Items.AddRange(new object[] {
            "NONE",
            "First Name",
            "Last Name",
            "Last Account Activity",
            "Total Hours",
            "# of Records"});
            this.lstSortBy.Location = new System.Drawing.Point(63, 13);
            this.lstSortBy.Name = "lstSortBy";
            this.lstSortBy.Size = new System.Drawing.Size(120, 95);
            this.lstSortBy.TabIndex = 2;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(16, 13);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(41, 13);
            this.lblSortBy.TabIndex = 1;
            this.lblSortBy.Text = "Sort By";
            // 
            // tbEditUser
            // 
            this.tbEditUser.Controls.Add(this.btnUserDelete);
            this.tbEditUser.Controls.Add(this.btnUserEdit);
            this.tbEditUser.Controls.Add(this.cboUserSelect);
            this.tbEditUser.Location = new System.Drawing.Point(4, 22);
            this.tbEditUser.Name = "tbEditUser";
            this.tbEditUser.Padding = new System.Windows.Forms.Padding(3);
            this.tbEditUser.Size = new System.Drawing.Size(890, 437);
            this.tbEditUser.TabIndex = 6;
            this.tbEditUser.Text = "Edit User";
            this.tbEditUser.UseVisualStyleBackColor = true;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Enabled = false;
            this.btnUserDelete.Location = new System.Drawing.Point(88, 35);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(75, 23);
            this.btnUserDelete.TabIndex = 1;
            this.btnUserDelete.Text = "&Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Enabled = false;
            this.btnUserEdit.Location = new System.Drawing.Point(7, 35);
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Size = new System.Drawing.Size(75, 23);
            this.btnUserEdit.TabIndex = 1;
            this.btnUserEdit.Text = "&Edit";
            this.btnUserEdit.UseVisualStyleBackColor = true;
            this.btnUserEdit.Click += new System.EventHandler(this.btnUserEdit_Click);
            // 
            // cboUserSelect
            // 
            this.cboUserSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboUserSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboUserSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserSelect.FormattingEnabled = true;
            this.cboUserSelect.Location = new System.Drawing.Point(7, 7);
            this.cboUserSelect.Name = "cboUserSelect";
            this.cboUserSelect.Size = new System.Drawing.Size(156, 21);
            this.cboUserSelect.TabIndex = 0;
            this.cboUserSelect.SelectedIndexChanged += new System.EventHandler(this.cboUserSelect_SelectedIndexChanged);
            // 
            // tbTimestamp
            // 
            this.tbTimestamp.Location = new System.Drawing.Point(4, 22);
            this.tbTimestamp.Name = "tbTimestamp";
            this.tbTimestamp.Size = new System.Drawing.Size(890, 437);
            this.tbTimestamp.TabIndex = 2;
            this.tbTimestamp.Text = "Timestamps";
            this.tbTimestamp.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(4, 22);
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(890, 437);
            this.tbReport.TabIndex = 3;
            this.tbReport.Text = "Report";
            this.tbReport.UseVisualStyleBackColor = true;
            // 
            // tbMaintenance
            // 
            this.tbMaintenance.Location = new System.Drawing.Point(4, 22);
            this.tbMaintenance.Name = "tbMaintenance";
            this.tbMaintenance.Size = new System.Drawing.Size(890, 437);
            this.tbMaintenance.TabIndex = 4;
            this.tbMaintenance.Text = "Maintenance";
            this.tbMaintenance.UseVisualStyleBackColor = true;
            // 
            // tbExport
            // 
            this.tbExport.Location = new System.Drawing.Point(4, 22);
            this.tbExport.Name = "tbExport";
            this.tbExport.Size = new System.Drawing.Size(890, 437);
            this.tbExport.TabIndex = 5;
            this.tbExport.Text = "Export";
            this.tbExport.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 487);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbUsers.ResumeLayout(false);
            this.tbUsers.PerformLayout();
            this.tbEditUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbWelcome;
        private System.Windows.Forms.TabPage tbUsers;
        private System.Windows.Forms.TabPage tbTimestamp;
        private System.Windows.Forms.TabPage tbReport;
        private System.Windows.Forms.TabPage tbMaintenance;
        private System.Windows.Forms.TabPage tbExport;
        private System.Windows.Forms.ListBox lstSortBy;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.CheckBox chkAscending;
        private System.Windows.Forms.Button btnUsersSubmit;
        private System.Windows.Forms.ListView lvUsersOutput;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TabPage tbEditUser;
        private System.Windows.Forms.ComboBox cboUserSelect;
        private System.Windows.Forms.Button btnUserEdit;
        private System.Windows.Forms.Button btnUserDelete;
    }
}