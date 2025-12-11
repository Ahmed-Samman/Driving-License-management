using Driving_License_management;
using System;
using DVLDBusinessLayer;
using System.Windows.Forms;
using System.Data;

namespace UserInterFacelayer
{
    public partial class frmManagePeople : Form
    {

        DataTable dt = clsPeopleBusinessLayer.List();


        public frmManagePeople()
        {
            InitializeComponent();
            _AddFilterBy();


        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshDataGrid();


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

      

        private void _RefreshDataGrid()
        {

            dgvManagePeople.DataSource = dt;
            
            // For Hide A Column
            dgvManagePeople.Columns["NationalityCountryID"].Visible = false;
            dgvManagePeople.Columns["ImagePath"].Visible = false;
        }

        private void dgvManagePeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void _AddFilterBy()
        {
            combFilterBy.Items.Add("None");
            combFilterBy.Items.Add("PersonID");
            combFilterBy.Items.Add("NationalNo");
            combFilterBy.Items.Add("FirstName");
            combFilterBy.Items.Add("SecondName");
            combFilterBy.Items.Add("ThirdName");
            combFilterBy.Items.Add("LastName");
            combFilterBy.Items.Add("Nationality");
            combFilterBy.Items.Add("Gendor");
            combFilterBy.Items.Add("Phone");
            combFilterBy.Items.Add("Email");

            combFilterBy.SelectedIndex = 0;
        }


        private void combFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combFilterBy.SelectedIndex != 0)
            {     
                txtbSearchBy.Visible = true;               
            }
            else
            {    
                txtbSearchBy.Visible = false;
                dgvManagePeople.DataSource = dt;
            }
        }

        private void txtbSearchBy_TextChanged(object sender, EventArgs e)
        {

            DataView dv = new DataView(dt);

            // To insure this ComboBox.SelectedIndex == PersonID
            if (combFilterBy.SelectedIndex == 1)
            {
                if (int.TryParse(txtbSearchBy.Text, out int PersonID))
                    dv.RowFilter = $"{combFilterBy.SelectedItem} = {PersonID}";
            }
            else
            {
                dv.RowFilter = $"{combFilterBy.SelectedItem} like '{txtbSearchBy.Text}%'";
            }
            dgvManagePeople.DataSource = dv;  
        }
    }
}
