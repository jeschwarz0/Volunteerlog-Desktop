namespace VolunteerLog
{
    partial class frmTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTask));
            this.chkClass = new System.Windows.Forms.CheckBox();
            this.chkOffice = new System.Windows.Forms.CheckBox();
            this.chkMaintenance = new System.Windows.Forms.CheckBox();
            this.chkConditioning = new System.Windows.Forms.CheckBox();
            this.chkHorseCare = new System.Windows.Forms.CheckBox();
            this.chkCommittee = new System.Windows.Forms.CheckBox();
            this.chkBoard = new System.Windows.Forms.CheckBox();
            this.chkJrVolunteer = new System.Windows.Forms.CheckBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.txtOtherDesc = new System.Windows.Forms.TextBox();
            this.cmdDone = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.chkSpecialOlympics = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkClass
            // 
            this.chkClass.AutoSize = true;
            this.chkClass.Location = new System.Drawing.Point(12, 10);
            this.chkClass.Name = "chkClass";
            this.chkClass.Size = new System.Drawing.Size(51, 17);
            this.chkClass.TabIndex = 1;
            this.chkClass.Text = "Class";
            this.chkClass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkClass.UseVisualStyleBackColor = true;
            // 
            // chkOffice
            // 
            this.chkOffice.AutoSize = true;
            this.chkOffice.Location = new System.Drawing.Point(12, 33);
            this.chkOffice.Name = "chkOffice";
            this.chkOffice.Size = new System.Drawing.Size(54, 17);
            this.chkOffice.TabIndex = 2;
            this.chkOffice.Text = "Office";
            this.chkOffice.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkOffice.UseVisualStyleBackColor = true;
            // 
            // chkMaintenance
            // 
            this.chkMaintenance.AutoSize = true;
            this.chkMaintenance.Location = new System.Drawing.Point(12, 56);
            this.chkMaintenance.Name = "chkMaintenance";
            this.chkMaintenance.Size = new System.Drawing.Size(88, 17);
            this.chkMaintenance.TabIndex = 3;
            this.chkMaintenance.Text = "Maintenance";
            this.chkMaintenance.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkMaintenance.UseVisualStyleBackColor = true;
            // 
            // chkConditioning
            // 
            this.chkConditioning.AutoSize = true;
            this.chkConditioning.Location = new System.Drawing.Point(12, 79);
            this.chkConditioning.Name = "chkConditioning";
            this.chkConditioning.Size = new System.Drawing.Size(84, 17);
            this.chkConditioning.TabIndex = 4;
            this.chkConditioning.Text = "Conditioning";
            this.chkConditioning.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkConditioning.UseVisualStyleBackColor = true;
            // 
            // chkHorseCare
            // 
            this.chkHorseCare.AutoSize = true;
            this.chkHorseCare.Location = new System.Drawing.Point(12, 102);
            this.chkHorseCare.Name = "chkHorseCare";
            this.chkHorseCare.Size = new System.Drawing.Size(79, 17);
            this.chkHorseCare.TabIndex = 5;
            this.chkHorseCare.Text = "Horse Care";
            this.chkHorseCare.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkHorseCare.UseVisualStyleBackColor = true;
            // 
            // chkCommittee
            // 
            this.chkCommittee.AutoSize = true;
            this.chkCommittee.Location = new System.Drawing.Point(12, 125);
            this.chkCommittee.Name = "chkCommittee";
            this.chkCommittee.Size = new System.Drawing.Size(75, 17);
            this.chkCommittee.TabIndex = 6;
            this.chkCommittee.Text = "Committee";
            this.chkCommittee.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkCommittee.UseVisualStyleBackColor = true;
            // 
            // chkBoard
            // 
            this.chkBoard.AutoSize = true;
            this.chkBoard.Location = new System.Drawing.Point(12, 148);
            this.chkBoard.Name = "chkBoard";
            this.chkBoard.Size = new System.Drawing.Size(54, 17);
            this.chkBoard.TabIndex = 7;
            this.chkBoard.Text = "Board";
            this.chkBoard.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkBoard.UseVisualStyleBackColor = true;
            // 
            // chkJrVolunteer
            // 
            this.chkJrVolunteer.AutoSize = true;
            this.chkJrVolunteer.Location = new System.Drawing.Point(12, 171);
            this.chkJrVolunteer.Name = "chkJrVolunteer";
            this.chkJrVolunteer.Size = new System.Drawing.Size(82, 17);
            this.chkJrVolunteer.TabIndex = 8;
            this.chkJrVolunteer.Text = "Jr Volunteer";
            this.chkJrVolunteer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkJrVolunteer.UseVisualStyleBackColor = true;
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(12, 217);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(52, 17);
            this.chkOther.TabIndex = 10;
            this.chkOther.Text = "Other";
            this.chkOther.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkOther.UseVisualStyleBackColor = true;
            this.chkOther.CheckedChanged += new System.EventHandler(this.chkOther_CheckedChanged);
            // 
            // txtOtherDesc
            // 
            this.txtOtherDesc.Enabled = false;
            this.txtOtherDesc.Location = new System.Drawing.Point(10, 240);
            this.txtOtherDesc.MaxLength = 16777215;
            this.txtOtherDesc.Multiline = true;
            this.txtOtherDesc.Name = "txtOtherDesc";
            this.txtOtherDesc.Size = new System.Drawing.Size(282, 75);
            this.txtOtherDesc.TabIndex = 11;
            // 
            // cmdDone
            // 
            this.cmdDone.Location = new System.Drawing.Point(219, 323);
            this.cmdDone.Name = "cmdDone";
            this.cmdDone.Size = new System.Drawing.Size(75, 23);
            this.cmdDone.TabIndex = 13;
            this.cmdDone.Text = "&Done";
            this.cmdDone.UseVisualStyleBackColor = true;
            this.cmdDone.Click += new System.EventHandler(this.cmdDone_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(138, 323);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 12;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // chkSpecialOlympics
            // 
            this.chkSpecialOlympics.AutoSize = true;
            this.chkSpecialOlympics.Location = new System.Drawing.Point(12, 194);
            this.chkSpecialOlympics.Name = "chkSpecialOlympics";
            this.chkSpecialOlympics.Size = new System.Drawing.Size(106, 17);
            this.chkSpecialOlympics.TabIndex = 9;
            this.chkSpecialOlympics.Text = "Special Olympics";
            this.chkSpecialOlympics.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkSpecialOlympics.UseVisualStyleBackColor = true;
            // 
            // frmTask
            // 
            this.AcceptButton = this.cmdDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(304, 355);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdDone);
            this.Controls.Add(this.txtOtherDesc);
            this.Controls.Add(this.chkOther);
            this.Controls.Add(this.chkSpecialOlympics);
            this.Controls.Add(this.chkJrVolunteer);
            this.Controls.Add(this.chkBoard);
            this.Controls.Add(this.chkCommittee);
            this.Controls.Add(this.chkHorseCare);
            this.Controls.Add(this.chkConditioning);
            this.Controls.Add(this.chkMaintenance);
            this.Controls.Add(this.chkOffice);
            this.Controls.Add(this.chkClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTask";
            this.Text = "Task";
            this.Load += new System.EventHandler(this.frmTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkClass;
        private System.Windows.Forms.CheckBox chkOffice;
        private System.Windows.Forms.CheckBox chkMaintenance;
        private System.Windows.Forms.CheckBox chkConditioning;
        private System.Windows.Forms.CheckBox chkHorseCare;
        private System.Windows.Forms.CheckBox chkCommittee;
        private System.Windows.Forms.CheckBox chkBoard;
        private System.Windows.Forms.CheckBox chkJrVolunteer;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.TextBox txtOtherDesc;
        private System.Windows.Forms.Button cmdDone;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.CheckBox chkSpecialOlympics;
    }
}