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
using static System.Net.Mime.MediaTypeNames;

namespace Driving_License_management
{
    public partial class ctrlAddEditPerson : UserControl
    {
        public ctrlAddEditPerson()
        {
            InitializeComponent();
        }
        public ctrlAddEditPerson(clsPeopleBusinessLayer _Person)
        {
            InitializeComponent();

            _Person.FirstName = this.FirstName;
            _Person.SecondName = this.SecondName;
            _Person.ThirdName = this.ThirdName;
            _Person.LastName = this.LastName;
            _Person.NationalNO = this.National_NO;
            _Person.DateOfBirth = this.DateOfBirth;
            _Person.Phone = this.Phone;
            _Person.Gender = this.Gendor;
            _Person.Email = this.Email;
            _Person.Address = this.Address;
            _Person.NationalityCountryID = this.CountryID;
        }

            //Declare Delegate
            //public delegate void SendDataBackHandler(object sender, int PersonID);

            //Declare an Event using the delegate
            //public event SendDataBackHandler SendDataBack;


            string FirstName { get; set; }
            string SecondName { get; set; }
            string ThirdName { get; set; }
            string LastName { get; set; }
            string National_NO { get; set; }
            DateTime DateOfBirth { get; set; }
            string Phone { get; set; }
            byte Gendor { get; set; }
            string Email { get; set; }
            string Address { get; set; }
            int CountryID { get; set; }

     
        private string TextValidation(TextBox txt, string FieldName)
        {
            // just Validation For txtEmail
            if (txt.Tag != null && txt.Tag.ToString() == "Email")
            {
                if ((!txt.Text.EndsWith("@gmail.com")) && (!string.IsNullOrEmpty(txt.Text)))
                {
                    txt.Focus();
                    errorProvider1.SetError(txt, FieldName);
                    return "";
                }
                else
                {               
                    errorProvider1.SetError(txt, "");
                    return txt.Text.ToString();
                }           
            }
        

            // Validation for another TextBox
            if(string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Focus();
                errorProvider1.SetError(txt, FieldName);
            }
            else
            {
                errorProvider1.SetError(txt, "");              
            }
            return txt.Text.ToString();
        }
        private void TextCheck(TextBox txt)
        {
            if (txt == txtFirstName)
            {
                FirstName = TextValidation(txt, "You Must Add First Name!");
            }
            else if(txt == txtSecondName)
            {
                SecondName = TextValidation(txt, "You Must Add Second Name!");
            }
            else if(txt == txtThirdName)
            {
                ThirdName = txt.Text;
            }
            else if (txt == txtLastName)
            {
                LastName = TextValidation(txt, "You Must Add Last Name!");
            }
            else if (txt == txtEmail)
            {
                Email = TextValidation(txt, "You Must Add Your Email!");
            }
            else if (txt == txtAddress)
            {
                Address = TextValidation(txt, "You Must Add Your Address!");
            }
            else if (txt == txtPhone)
            {
                Phone = TextValidation(txt, "You Must Add Your Phone!");
            }
        }
        private void Text_Validating(object sender, CancelEventArgs e)
        {
            TextCheck((TextBox)sender);
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            DateOfBirth = dtpDateOfBirth.Value;
        }


        // For Choose Gender
        private void Male_FemaleCheck(RadioButton sender)
        {
            if (sender.Checked)
                Gendor = Convert.ToByte(sender.Tag);
        }
        private void Male_FemaleCheckedChanged(object sender, EventArgs e)
        {
            Male_FemaleCheck((RadioButton)sender);
        }

        private void ctrlAddEditPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
