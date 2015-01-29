using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VolunteerLog
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                cboName.DataSource = Program.vc.getUsersNC();// Load cboName with all volunteer names
            }
            catch (DatabaseNotOpenException) { Program.forceQuit(); }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();//close this form
        }

        private void cmdDone_Click(object sender, EventArgs e)
        {
            uint? vid;//volunteerid

            try { vid = Program.vc.getVolunteerIDFromName(cboName.Text); }//get the name of the volunteer
            catch (DatabaseNotOpenException) { Program.forceQuit(); return; }//return required for compiler

            if(vid!=null){
                try
                {
                    Program.vc.insertCheckin(vid.Value);//do the transaction, login...
                }
                catch (DatabaseNotOpenException) { Program.forceQuit(); }

                this.Close();//close this form
            }

            
        }
    }
}
