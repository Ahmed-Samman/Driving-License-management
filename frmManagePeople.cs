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
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

      

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frmAddEditPerson = new frmAdd_EditPersonInfo("Add New Person");
            frmAddEditPerson.ShowDialog();
        }

     

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            Form frmDetailP = new frmPersonDetails();
            frmDetailP.ShowDialog();
        }

        private void tsmAddNewPerson_Click(object sender, EventArgs e)
        {
            Form frmAddEditPerson = new frmAdd_EditPersonInfo("Add New Person");
            frmAddEditPerson.ShowDialog();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            Form frmAddEditPerson = new frmAdd_EditPersonInfo("     Update Person");      
            frmAddEditPerson.ShowDialog();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {

        }
    }
}
