using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_management
{
    public partial class frmMangeUser : Form
    {
        public frmMangeUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form frmAddUser = new frmAddNewUser("Add New User");
            frmAddUser.Text = "Add New User";
            frmAddUser.ShowDialog();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            Form frmAddUser = new frmAddNewUser("Update User");
            frmAddUser.Text = "Update User";
            frmAddUser.ShowDialog();
        }

        private void tsmAddNewUser_Click(object sender, EventArgs e)
        {
            Form frmAddUser = new frmAddNewUser("Add New User");
            frmAddUser.ShowDialog();
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            Form frmChangePassword = new frmChangePassword();
            frmChangePassword.ShowDialog();
        }
    }
}
