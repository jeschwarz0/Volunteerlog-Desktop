namespace VolunteerLog
{
    partial class frmEditUser
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
            this.txtLN = new System.Windows.Forms.TextBox();
            this.lblLN = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.lblFN = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(78, 32);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(100, 20);
            this.txtLN.TabIndex = 7;
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Location = new System.Drawing.Point(12, 35);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(61, 13);
            this.lblLN.TabIndex = 8;
            this.lblLN.Text = "Last Name:";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(78, 12);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(100, 20);
            this.txtFN.TabIndex = 5;
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(12, 15);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(60, 13);
            this.lblFN.TabIndex = 6;
            this.lblFN.Text = "First Name:";
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(22, 58);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 9;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdDone
            // 
            this.cmdDone.Location = new System.Drawing.Point(103, 58);
            this.cmdDone.Name = "cmdDone";
            this.cmdDone.Size = new System.Drawing.Size(75, 23);
            this.cmdDone.TabIndex = 10;
            this.cmdDone.Text = "&Done";
            this.cmdDone.UseVisualStyleBackColor = true;
            this.cmdDone.Click += new System.EventHandler(this.cmdDone_Click);
            // 
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 86);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdDone);
            this.Name = "frmEditUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Edit User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdDone;
    }
}