using Driving_License_management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterFacelayer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void msPeople_Click(object sender, EventArgs e)
        {
            Form frmMPeople = new frmManagePeople();
            frmMPeople.ShowDialog();
        }

        private void msUsers_Click(object sender, EventArgs e)
        {
            Form frmMUsers = new frmMangeUser();
            frmMUsers.ShowDialog();
        }

        private void msApplications_Click(object sender, EventArgs e)
        {

        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            Form frmChangePassword = new frmChangePassword();
            frmChangePassword.ShowDialog();
        }

        private void ctsmCurrentUserInfo_Click(object sender, EventArgs e)
        {
            Form frmCurrentUserInfo = new frmUserInfo();
            frmCurrentUserInfo.ShowDialog();
        }
    }
}
