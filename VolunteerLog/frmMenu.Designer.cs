namespace VolunteerLog
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblHeader = new System.Windows.Forms.Label();
            this.cmdJoin = new System.Windows.Forms.Button();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdLogout = new System.Windows.Forms.Button();
            this.cmdManual = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(206, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Volunteer Sign-in";
            // 
            // cmdJoin
            // 
            this.cmdJoin.Location = new System.Drawing.Point(39, 46);
            this.cmdJoin.Name = "cmdJoin";
            this.cmdJoin.Size = new System.Drawing.Size(75, 23);
            this.cmdJoin.TabIndex = 1;
            this.cmdJoin.Text = "&Join";
            this.cmdJoin.UseVisualStyleBackColor = true;
            this.cmdJoin.Click += new System.EventHandler(this.cmdJoin_Click);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(39, 75);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(75, 23);
            this.cmdLogin.TabIndex = 2;
            this.cmdLogin.Text = "Log&in";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // cmdLogout
            // 
            this.cmdLogout.Location = new System.Drawing.Point(120, 75);
            this.cmdLogout.Name = "cmdLogout";
            this.cmdLogout.Size = new System.Drawing.Size(75, 23);
            this.cmdLogout.TabIndex = 3;
            this.cmdLogout.Text = "Log&out";
            this.cmdLogout.UseVisualStyleBackColor = true;
            this.cmdLogout.Click += new System.EventHandler(this.cmdLogout_Click);
            // 
            // cmdManual
            // 
            this.cmdManual.Location = new System.Drawing.Point(39, 104);
            this.cmdManual.Name = "cmdManual";
            this.cmdManual.Size = new System.Drawing.Size(75, 23);
            this.cmdManual.TabIndex = 4;
            this.cmdManual.Text = "&Manual";
            this.cmdManual.UseVisualStyleBackColor = true;
            this.cmdManual.Click += new System.EventHandler(this.cmdManual_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdExit.Location = new System.Drawing.Point(120, 104);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 5;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdExit;
            this.ClientSize = new System.Drawing.Size(244, 151);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdManual);
            this.Controls.Add(this.cmdLogout);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.cmdJoin);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Text = "North Country R.I.D.E.";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button cmdJoin;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Button cmdLogout;
        private System.Windows.Forms.Button cmdManual;
        private System.Windows.Forms.Button cmdExit;
    }
}

