﻿namespace VolunteerLog
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.cmdDone = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdDone
            // 
            this.cmdDone.Location = new System.Drawing.Point(107, 34);
            this.cmdDone.Name = "cmdDone";
            this.cmdDone.Size = new System.Drawing.Size(75, 23);
            this.cmdDone.TabIndex = 3;
            this.cmdDone.Text = "&Done";
            this.cmdDone.UseVisualStyleBackColor = true;
            this.cmdDone.Click += new System.EventHandler(this.cmdDone_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(26, 34);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Items.AddRange(new object[] {
            "Jesse Schwarz"});
            this.cboName.Location = new System.Drawing.Point(52, 7);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(130, 21);
            this.cboName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.cmdDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(197, 63);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDone;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Label label1;
    }
}