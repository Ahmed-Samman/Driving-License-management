using DVLDBusinessLayer;
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
    public partial class frmAdd_EditPersonInfo : Form
    {

        clsPeopleBusinessLayer _Person = new clsPeopleBusinessLayer();

        public frmAdd_EditPersonInfo(string Add_EditPerson)
        {
            InitializeComponent();
            lblAddEditPerson.Text = Add_EditPerson;

            //Subscribe to the Event
            ctrlAddEditPerson1.SaveClicked += Ctrl_SaveClicked;
            ctrlAddEditPerson1.CloseClicked += Ctrl_CloseClicked;
        }
        
        private void _SavePerson(object sender, EventArgs e)
        {
           

            _Person.FirstName = ctrlAddEditPerson1.FirstName;
            _Person.SecondName = ctrlAddEditPerson1.SecondName;
            _Person.ThirdName = ctrlAddEditPerson1.ThirdName;
            _Person.LastName = ctrlAddEditPerson1.LastName;
            _Person.NationalNO = ctrlAddEditPerson1.National_NO;
            _Person.DateOfBirth = ctrlAddEditPerson1.DateOfBirth;
            _Person.Phone = ctrlAddEditPerson1.Phone;
            _Person.Gender = ctrlAddEditPerson1.Gendor;
            _Person.Email = ctrlAddEditPerson1.Email;
            _Person.Address = ctrlAddEditPerson1.Address;
            _Person.NationalityCountryID = ctrlAddEditPerson1.CountryID;
            _Person.ImagePath = ctrlAddEditPerson1.ImagePath;

            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Succesfuly!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPersonID.Text = _Person.PersonID.ToString();
            }
            else
            {
                MessageBox.Show("Data Saved Faild!");
            }
        }

        private void Ctrl_SaveClicked(object sender, EventArgs e)
        {
            _SavePerson(sender, e);
        }
        private void Ctrl_CloseClicked(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
