namespace VolunteerLog
{
    partial class frmJoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJoin));
            this.cmdDone = new System.Windows.Forms.Button();
            this.lblFN = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.lblLN = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdDone
            // 
            this.cmdDone.Location = new System.Drawing.Point(98, 55);
            this.cmdDone.Name = "cmdDone";
            this.cmdDone.Size = new System.Drawing.Size(75, 23);
            this.cmdDone.TabIndex = 4;
            this.cmdDone.Text = "&Done";
            this.cmdDone.UseVisualStyleBackColor = true;
            this.cmdDone.Click += new System.EventHandler(this.cmdDone_Click);
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(7, 12);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(60, 13);
            this.lblFN.TabIndex = 1;
            this.lblFN.Text = "First Name:";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(73, 9);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(100, 20);
            this.txtFN.TabIndex = 1;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(73, 29);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(100, 20);
            this.txtLN.TabIndex = 2;
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Location = new System.Drawing.Point(7, 32);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(61, 13);
            this.lblLN.TabIndex = 3;
            this.lblLN.Text = "Last Name:";
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(17, 55);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmJoin
            // 
            this.AcceptButton = this.cmdDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(184, 84);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJoin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Join";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDone;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Button cmdCancel;
    }
}