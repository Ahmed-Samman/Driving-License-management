using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_License_management
{
    public partial class frmAdd_EditPersonInfo : Form
    {

        enum enMode { AddPerson = 1, EditPerson = 2};
        enMode Mode = enMode.AddPerson;

        clsPeopleBusinessLayer _Person;

        public frmAdd_EditPersonInfo(int PersonID)
        {
            InitializeComponent();

            ctrlAddEditPerson1.FillCombo_Countries();

            if (PersonID == -1)
            {
                lblAddEditPerson.Text = "Add New Person";
                Mode = enMode.AddPerson;
                ctrlAddEditPerson1.NationalNum_ReadOnly = false;
            }
            else
            {
                Mode = enMode.EditPerson;
                lblAddEditPerson.Text = "Update Person";
                lblPersonID.Text = PersonID.ToString();
                ctrlAddEditPerson1.NationalNum_ReadOnly = true;
                _LoadPersonData(PersonID);
            }

            //Subscribe to the Event
            ctrlAddEditPerson1.SaveClicked += Ctrl_SaveClicked;
            ctrlAddEditPerson1.CloseClicked += Ctrl_CloseClicked;
        }
        
        private void _SavePerson(object sender, EventArgs e)
        {

            if (Mode == enMode.AddPerson)
            {
                _Person = new clsPeopleBusinessLayer();   
            }
           
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

        private void _LoadPersonData(int PersonID)
        {
            _Person = clsPeopleBusinessLayer.FindPersonInfoByID(PersonID);

            if(_Person == null)
            {
                MessageBox.Show("Opps! This Person IS Not Found...!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlAddEditPerson1.FirstName = _Person.FirstName;
            ctrlAddEditPerson1.SecondName = _Person.SecondName;
            ctrlAddEditPerson1.ThirdName = _Person.ThirdName;
            ctrlAddEditPerson1.LastName = _Person.LastName;
            ctrlAddEditPerson1.National_NO = _Person.NationalNO;
            ctrlAddEditPerson1.DateOfBirth = _Person.DateOfBirth;
            ctrlAddEditPerson1.Phone = _Person.Phone;
            ctrlAddEditPerson1.Gendor = _Person.Gender;
            ctrlAddEditPerson1.Email = _Person.Email;
            ctrlAddEditPerson1.Address = _Person.Address;
            ctrlAddEditPerson1.CountryID = _Person.NationalityCountryID;
            ctrlAddEditPerson1.OldImagePath = _Person.ImagePath;

            ctrlAddEditPerson1.FillUserControl();
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
