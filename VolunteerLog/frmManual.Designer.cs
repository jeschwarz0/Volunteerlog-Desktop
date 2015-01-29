namespace VolunteerLog
{
    partial class frmManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManual));
            this.lblName = new System.Windows.Forms.Label();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdDone = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpIn = new System.Windows.Forms.GroupBox();
            this.lblInTP = new System.Windows.Forms.Label();
            this.nudInMin = new System.Windows.Forms.NumericUpDown();
            this.nudInHour = new System.Windows.Forms.NumericUpDown();
            this.grpOut = new System.Windows.Forms.GroupBox();
            this.lblOutTP = new System.Windows.Forms.Label();
            this.nudOutMin = new System.Windows.Forms.NumericUpDown();
            this.nudOutHour = new System.Windows.Forms.NumericUpDown();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.grpIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInHour)).BeginInit();
            this.grpOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutHour)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Items.AddRange(new object[] {
            "Jesse Schwarz"});
            this.cboName.Location = new System.Drawing.Point(50, 12);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(200, 21);
            this.cboName.TabIndex = 1;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(94, 245);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdDone
            // 
            this.cmdDone.Location = new System.Drawing.Point(175, 245);
            this.cmdDone.Name = "cmdDone";
            this.cmdDone.Size = new System.Drawing.Size(75, 23);
            this.cmdDone.TabIndex = 7;
            this.cmdDone.Text = "&Done";
            this.cmdDone.UseVisualStyleBackColor = true;
            this.cmdDone.Click += new System.EventHandler(this.cmdDone_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = false;
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Location = new System.Drawing.Point(50, 39);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date:";
            // 
            // grpIn
            // 
            this.grpIn.Controls.Add(this.lblInTP);
            this.grpIn.Controls.Add(this.nudInMin);
            this.grpIn.Controls.Add(this.nudInHour);
            this.grpIn.Location = new System.Drawing.Point(12, 65);
            this.grpIn.Name = "grpIn";
            this.grpIn.Size = new System.Drawing.Size(143, 48);
            this.grpIn.TabIndex = 3;
            this.grpIn.TabStop = false;
            this.grpIn.Text = "In";
            // 
            // lblInTP
            // 
            this.lblInTP.AutoSize = true;
            this.lblInTP.BackColor = System.Drawing.Color.DarkGray;
            this.lblInTP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInTP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInTP.ForeColor = System.Drawing.Color.Yellow;
            this.lblInTP.Location = new System.Drawing.Point(110, 21);
            this.lblInTP.Name = "lblInTP";
            this.lblInTP.Size = new System.Drawing.Size(27, 15);
            this.lblInTP.TabIndex = 3;
            this.lblInTP.Text = "PM";
            this.lblInTP.Click += new System.EventHandler(this.lblInTP_Click);
            // 
            // nudInMin
            // 
            this.nudInMin.Location = new System.Drawing.Point(58, 19);
            this.nudInMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudInMin.Name = "nudInMin";
            this.nudInMin.Size = new System.Drawing.Size(46, 20);
            this.nudInMin.TabIndex = 2;
            // 
            // nudInHour
            // 
            this.nudInHour.Location = new System.Drawing.Point(6, 19);
            this.nudInHour.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudInHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInHour.Name = "nudInHour";
            this.nudInHour.Size = new System.Drawing.Size(46, 20);
            this.nudInHour.TabIndex = 1;
            this.nudInHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpOut
            // 
            this.grpOut.Controls.Add(this.lblOutTP);
            this.grpOut.Controls.Add(this.nudOutMin);
            this.grpOut.Controls.Add(this.nudOutHour);
            this.grpOut.Location = new System.Drawing.Point(12, 119);
            this.grpOut.Name = "grpOut";
            this.grpOut.Size = new System.Drawing.Size(143, 48);
            this.grpOut.TabIndex = 4;
            this.grpOut.TabStop = false;
            this.grpOut.Text = "Out";
            // 
            // lblOutTP
            // 
            this.lblOutTP.AutoSize = true;
            this.lblOutTP.BackColor = System.Drawing.Color.DarkGray;
            this.lblOutTP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutTP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutTP.ForeColor = System.Drawing.Color.Yellow;
            this.lblOutTP.Location = new System.Drawing.Point(110, 21);
            this.lblOutTP.Name = "lblOutTP";
            this.lblOutTP.Size = new System.Drawing.Size(27, 15);
            this.lblOutTP.TabIndex = 4;
            this.lblOutTP.Text = "PM";
            this.lblOutTP.Click += new System.EventHandler(this.lblOutTP_Click);
            // 
            // nudOutMin
            // 
            this.nudOutMin.Location = new System.Drawing.Point(58, 19);
            this.nudOutMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudOutMin.Name = "nudOutMin";
            this.nudOutMin.Size = new System.Drawing.Size(46, 20);
            this.nudOutMin.TabIndex = 2;
            // 
            // nudOutHour
            // 
            this.nudOutHour.Location = new System.Drawing.Point(6, 19);
            this.nudOutHour.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudOutHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOutHour.Name = "nudOutHour";
            this.nudOutHour.Size = new System.Drawing.Size(46, 20);
            this.nudOutHour.TabIndex = 1;
            this.nudOutHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(12, 174);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(54, 13);
            this.lblComment.TabIndex = 10;
            this.lblComment.Text = "Comment:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(12, 190);
            this.txtComment.MaxLength = 16777215;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(240, 49);
            this.txtComment.TabIndex = 5;
            // 
            // frmManual
            // 
            this.AcceptButton = this.cmdDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(257, 275);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.grpOut);
            this.Controls.Add(this.grpIn);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManual";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Manual";
            this.Load += new System.EventHandler(this.frmManual_Load);
            this.grpIn.ResumeLayout(false);
            this.grpIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInHour)).EndInit();
            this.grpOut.ResumeLayout(false);
            this.grpOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdDone;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpIn;
        private System.Windows.Forms.Label lblInTP;
        private System.Windows.Forms.NumericUpDown nudInMin;
        private System.Windows.Forms.NumericUpDown nudInHour;
        private System.Windows.Forms.GroupBox grpOut;
        private System.Windows.Forms.Label lblOutTP;
        private System.Windows.Forms.NumericUpDown nudOutMin;
        private System.Windows.Forms.NumericUpDown nudOutHour;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
    }
}