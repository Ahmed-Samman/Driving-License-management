using Driving_License_management;
using System;
using DVLDBusinessLayer;
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
            _RefreshDataGrid();


        }

        private void _RefreshDataGrid()
        {
            dgvManagePeople.DataSource = clsPeopleBusinessLayer.List();

            // For Hide A Column
            dgvManagePeople.Columns["NationalityCountryID"].Visible = false;
            dgvManagePeople.Columns["ImagePath"].Visible = false;
        }

        private void dgvManagePeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
