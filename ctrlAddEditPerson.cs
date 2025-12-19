using Driving_License_management.Properties;
using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Driving_License_management
{
    public partial class ctrlAddEditPerson : UserControl
    {
         
         clsPeopleBusinessLayer _Person = new clsPeopleBusinessLayer();

         public ctrlAddEditPerson()
         {
             InitializeComponent();
             
            
         }
         
         
         ////Declare Delegate
         //public delegate void SendDataBackHandler(object sender, int PersonID);
         
         ////Declare an Event using the delegate
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
        string ImagePath { get; set; }

        private void ctrlAddEditPerson_Load(object sender, EventArgs e)
        {
            _FillCombo_Countries();
            DateOfBirth = dtpDateOfBirth.Value;
            CountryID = (int)combCountries.SelectedValue;


        }

        // ( Done )
        //1 For Checked On txtFirst, txtSecond, txtThird, txtLast, txtPhone and Address Using -> (errorProvider)
        private string ValidateNonEmptyText(TextBox txt, string Message, bool isOptional = false)
        {
            // Just First, Second, Last Name Not (ThirdName)
            if(!isOptional && string.IsNullOrWhiteSpace(txt.Text))
            {              
                txt.Focus();
                errorProvider1.SetError(txt, Message);
                return null;                                
            }
            errorProvider1.SetError(txt, "");
            return txt.Text.ToString(); 
        }
        private void LettersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        
        //2 Validation And Check On National Number
        private string ValidateNational_NO(TextBox txt, string Message)
        {
               
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Focus();
                errorProvider1.SetError(txt, Message);
                return null;
            }

            // Check is National Number Used
            bool isfound = clsPeopleBusinessLayer.Search_NationalNO(txt.Text.ToString());
            
            if (isfound)
            {
                txt.Focus();
                errorProvider1.SetError(txt, "National Number Is Used For Another Person!");
                return null;
            }
            errorProvider1.SetError(txt, "");
            return txt.Text.ToString();
        }

        //3 just Validation For txtEmail Using (errorProvider)
        private string ValidateEmail(TextBox txt, string Message)
        {         
            if ((!txt.Text.EndsWith("@gmail.com")) && (!string.IsNullOrEmpty(txt.Text)))
            {
                txt.Focus();
                errorProvider1.SetError(txt, Message);
                return null;
            }           
            errorProvider1.SetError(txt, "");
            return txt.Text.ToString();
        }

        //4 just Validation For txtPhone Using (KeyPress Event)     
        private void DigitOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
       
        //5 Add Date Of birth
        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            DateOfBirth = dtpDateOfBirth.Value;
        }

        //6 For Choose Gender
        private void Male_FemaleCheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMale.Checked)
            {
                Gendor = Convert.ToByte(rbtnMale.Tag);
                picboxImage.Image = Resources.person_man;
            }
            else
            {
                Gendor = Convert.ToByte(rbtnFemale.Tag);
                picboxImage.Image = Resources.person_woman;
            } 
        }

        // Send object sender (TextBox) to Required TextBox 
        private void TextCheck(TextBox txt)
        {
            if (txt == txtFirstName)
            {
                FirstName = ValidateNonEmptyText(txt, $"You Must Add {txt.Tag} Name!");
            }
            else if(txt == txtSecondName)
            {
                SecondName = ValidateNonEmptyText(txt, $"You Must Add {txt.Tag} Name!");
            }
            else if (txt == txtThirdName)
            {
                ThirdName = ValidateNonEmptyText(txt, $"You Must Add {txt.Tag} Name!", true);
            }
            else if (txt == txtLastName)
            {
                LastName = ValidateNonEmptyText(txt, $"You Must Add {txt.Tag} Name!");
            }
            else if(txt == txtNationalNo)
            {
                National_NO = ValidateNational_NO(txt, "You Must Add Your National_NO!");
            }
            else if (txt == txtEmail)
            {
                Email = ValidateEmail(txt, "You Must Add Your Email Well...!");
            }
            else if (txt == txtAddress)
            {
                Address = ValidateNonEmptyText(txt, "You Must Add Your Address!");
            }
            else if (txt == txtPhone)
            {
                Phone = ValidateNonEmptyText(txt, "You Must Add Your Phone!");
            }
        }
        private void Text_Validating(object sender, CancelEventArgs e)
        {
            TextCheck((TextBox)sender);
        }

        // Fill Countries In ComboBox
        private void _FillCombo_Countries()
        {
            DataTable dtCountries = clsPeopleBusinessLayer.GetAllCountries();

            combCountries.DataSource = dtCountries;
            combCountries.DisplayMember = "CountryName";
            combCountries.ValueMember = "CountryID";
            combCountries.SelectedValue = 51;
        }
        private void combCountries_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(combCountries.SelectedValue != null)
                CountryID = (int)combCountries.SelectedValue;
        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Person.FirstName = FirstName;
            _Person.SecondName = SecondName;
            _Person.ThirdName = ThirdName;
            _Person.LastName = LastName;
            _Person.NationalNO = National_NO;
            _Person.DateOfBirth = DateOfBirth;
            _Person.Phone = Phone;
            _Person.Gender = Gendor;
            _Person.Email = Email;
            _Person.Address = Address;
            _Person.NationalityCountryID = CountryID;
            _Person.ImagePath = ImagePath;

            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Succesfuly!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Saved Faild!");
            }
        }

    }
}
