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
    public partial class frmFindPerson : Form
    {
        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Form frmNewAddPerson = new frmAdd_EditPersonInfo("Add New Person");
            frmNewAddPerson.ShowDialog();
        }

        private void frmFindPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
