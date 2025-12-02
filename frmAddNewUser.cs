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
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }

        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            Form frmFindPerson = new frmFindPerson();
            frmFindPerson.ShowDialog();
        }

        private void btnNextPage2_Click(object sender, EventArgs e)
        {
            tabcPersonInfo.SelectedTab = tpage2LoginInfo;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
