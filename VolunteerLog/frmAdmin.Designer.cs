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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbWelcome = new System.Windows.Forms.TabPage();
            this.tbUsers = new System.Windows.Forms.TabPage();
            this.tbTimestamp = new System.Windows.Forms.TabPage();
            this.tbReport = new System.Windows.Forms.TabPage();
            this.tbMaintenance = new System.Windows.Forms.TabPage();
            this.tbExport = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tbUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbWelcome);
            this.tabControl1.Controls.Add(this.tbUsers);
            this.tabControl1.Controls.Add(this.tbTimestamp);
            this.tabControl1.Controls.Add(this.tbReport);
            this.tabControl1.Controls.Add(this.tbMaintenance);
            this.tabControl1.Controls.Add(this.tbExport);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // tbWelcome
            // 
            this.tbWelcome.Location = new System.Drawing.Point(4, 22);
            this.tbWelcome.Name = "tbWelcome";
            this.tbWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tbWelcome.Size = new System.Drawing.Size(890, 364);
            this.tbWelcome.TabIndex = 0;
            this.tbWelcome.Text = "Welcome";
            this.tbWelcome.UseVisualStyleBackColor = true;
            // 
            // tbUsers
            // 
            this.tbUsers.Controls.Add(this.tableLayoutPanel1);
            this.tbUsers.Location = new System.Drawing.Point(4, 22);
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tbUsers.Size = new System.Drawing.Size(890, 364);
            this.tbUsers.TabIndex = 1;
            this.tbUsers.Text = "Users";
            this.tbUsers.UseVisualStyleBackColor = true;
            // 
            // tbTimestamp
            // 
            this.tbTimestamp.Location = new System.Drawing.Point(4, 22);
            this.tbTimestamp.Name = "tbTimestamp";
            this.tbTimestamp.Size = new System.Drawing.Size(890, 364);
            this.tbTimestamp.TabIndex = 2;
            this.tbTimestamp.Text = "Timestamps";
            this.tbTimestamp.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(4, 22);
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(890, 364);
            this.tbReport.TabIndex = 3;
            this.tbReport.Text = "Report";
            this.tbReport.UseVisualStyleBackColor = true;
            // 
            // tbMaintenance
            // 
            this.tbMaintenance.Location = new System.Drawing.Point(4, 22);
            this.tbMaintenance.Name = "tbMaintenance";
            this.tbMaintenance.Size = new System.Drawing.Size(890, 364);
            this.tbMaintenance.TabIndex = 4;
            this.tbMaintenance.Text = "Maintenance";
            this.tbMaintenance.UseVisualStyleBackColor = true;
            // 
            // tbExport
            // 
            this.tbExport.Location = new System.Drawing.Point(4, 22);
            this.tbExport.Name = "tbExport";
            this.tbExport.Size = new System.Drawing.Size(890, 364);
            this.tbExport.TabIndex = 5;
            this.tbExport.Text = "Export";
            this.tbExport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(501, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 276);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 487);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.tabControl1.ResumeLayout(false);
            this.tbUsers.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}