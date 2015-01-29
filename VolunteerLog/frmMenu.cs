using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using libVL;

namespace VolunteerLog
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cmdJoin_Click(object sender, EventArgs e)
        {
            new frmJoin().ShowDialog(this);//show a new join dialog on self
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();//exit this form(and the app)
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            new frmLogin().ShowDialog(this);//show a new Login dialog on self
        }

        private void cmdManual_Click(object sender, EventArgs e)
        {
            Program.manual_path = true;//set path tristate to not manual
            Program.current_taskid = null;//set no current Taskid
            new frmTask().ShowDialog(this);//show a new Task dialog with bias of manual
        } 

        private void cmdLogout_Click(object sender, EventArgs e)
        {
            Program.manual_path = false;//set path tristate to not manual
            Program.current_taskid = null;//set no current Taskid
            new frmTask().ShowDialog(this);//show a new Task dialog with bias of Logout
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //crashes if not included***
        }

    }
}
