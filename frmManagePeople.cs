using Driving_License_management;
using System;
using DVLDBusinessLayer;
using System.Windows.Forms;
using System.Data;

namespace UserInterFacelayer
{
    public partial class frmManagePeople : Form
    {
        DataTable dt = new DataTable();
 
        public frmManagePeople()
        {
            InitializeComponent();
            _AddFilterBy();


        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshDataGrid();
            lbRecords.Text = dgvManagePeople.RowCount.ToString();

        }

        private void _RefreshDataGrid()
        {
            dt = clsPeopleBusinessLayer.List();
            dgvManagePeople.DataSource = dt;
        }

        // Add New Person (Button)
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frmAddEditPerson = new frmAdd_EditPersonInfo(-1);
            frmAddEditPerson.ShowDialog();
            _RefreshDataGrid();
        }
        
        
        // Search About Person By Filter
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


        // Choice Witch Column To Search By it
        private void combFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combFilterBy.SelectedIndex != 0)
            {
                txtbSearchBy.Visible = true;
            }
            else
            {
                txtbSearchBy.Visible = false;
                dgvManagePeople.DataSource = dt;
            }
        }


        // To Search By People Column Of Info
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


        // ---------------------- ContextMenuStrip ------------------//

        private void dgvManagePeople_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvManagePeople.ClearSelection();
                dgvManagePeople.Rows[e.RowIndex].Selected = true;
                dgvManagePeople.CurrentCell = dgvManagePeople.Rows[e.RowIndex].Cells[0];
            }
        }


        //1- Show Person Info
        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            Form frmDetailPerson = new frmPersonDetails();
            frmDetailPerson.ShowDialog();
        }


        //2- Add new Person
        private void tsmAddNewPerson_Click(object sender, EventArgs e)
        {
            Form frmAddEditPerson = new frmAdd_EditPersonInfo(-1);
            frmAddEditPerson.ShowDialog();
            _RefreshDataGrid();
        }


        //3- Update Person Info
        private void tsmEdit_Click(object sender, EventArgs e)
        {
            if (dgvManagePeople.SelectedRows.Count == 0)
                return;

            int PersonID = Convert.ToInt32(dgvManagePeople.SelectedRows[0].Cells["PersonID"].Value);

            Form frmAddEditPerson = new frmAdd_EditPersonInfo(PersonID);      
            frmAddEditPerson.ShowDialog();
            _RefreshDataGrid();
        }


        //4- Delete Person 
        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (dgvManagePeople.SelectedRows.Count == 0)
                return;

            int PersonID = Convert.ToInt32(dgvManagePeople.SelectedRows[0].Cells["PersonID"].Value);

            if (MessageBox.Show($"Do You Want To Delete This Person [{PersonID}]?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool CanDelete = clsPeopleBusinessLayer.IsDeleted(PersonID);

                if (CanDelete)
                {
                    MessageBox.Show("You Deleted Succesfuly", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshDataGrid();
                }
                else
                {
                    MessageBox.Show("You Cannot Delete This Person....!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }          
        }

       
      
    }
}