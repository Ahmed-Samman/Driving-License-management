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
            Form frmAddUser = new frmAddNewUser();
            frmAddUser.ShowDialog();
        }

        private void frmMangeUser_Load(object sender, EventArgs e)
        {

        }
    }
}
