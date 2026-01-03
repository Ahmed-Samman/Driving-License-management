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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Driving_License_management
{
    public partial class ctrlAddEditPerson : UserControl
    {
         public ctrlAddEditPerson()
         {
             InitializeComponent();        
         }

        //Declare Delegate  
        public event EventHandler SaveClicked;
        public event EventHandler CloseClicked;


        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string National_NO { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public byte Gendor { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }
        public string OldImagePath { get; set; }

        // If frmAdd-EditPerson On EditMode
        public bool NationalNum_ReadOnly 
        {
            get
            {
               return txtNationalNo.ReadOnly;
            }

            set
            {
                txtNationalNo.ReadOnly = value;
            }
        }



        // Fill All Controls In UserControl
        public void FillUserControl()
        {
            txtFirstName.Text = FirstName;
            txtSecondName.Text = SecondName;
            txtThirdName.Text = ThirdName;
            txtLastName.Text = LastName;
            txtNationalNo.Text = National_NO;
            dtpDateOfBirth.Value = DateOfBirth;
            txtPhone.Text = Phone;
            if (Gendor == 0)
                rbtnMale.Checked = true;
            else
                rbtnFemale.Checked = true;
            txtEmail.Text = Email;
            txtAddress.Text = Address;
            combCountries.SelectedValue = CountryID;
            picboxImage.ImageLocation = OldImagePath;
        }

        private void ctrlAddEditPerson_Load(object sender, EventArgs e)
        {       
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

            if (txtNationalNo.ReadOnly)
            {
                return txt.Text.ToString();
            }


            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Focus();
                errorProvider1.SetError(txt, Message);
                return null;
            }

            if (!Regex.IsMatch(txt.Text, @"^[nN]\d+$"))
            {

                txt.Focus();
                errorProvider1.SetError(txt, "Error! Enter (n) Or (N) And Any Number");
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
        public void FillCombo_Countries()
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


        // Check Is All TextBoxes Are Full?
        private bool IsAllInfoCompleted()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text)) return false;
            if (string.IsNullOrEmpty(txtSecondName.Text)) return false;
            if (string.IsNullOrEmpty(txtLastName.Text)) return false;
            if (string.IsNullOrEmpty(txtNationalNo.Text)) return false;
            if (string.IsNullOrEmpty(txtPhone.Text)) return false;
            if (string.IsNullOrEmpty(txtAddress.Text)) return false;
            if (!string.IsNullOrEmpty(ImagePath)) SaveInPeopleImagesFolder();

            return true;
        }


        // Add Image
        private void lnkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {    
            openFileDialog1.Filter = openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*"; ;
            openFileDialog1.Title = "Select Image";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImagePath = openFileDialog1.FileName;
                picboxImage.ImageLocation = ImagePath;
            }
            lnkRemove.Visible = true;
        }
        private bool SaveInPeopleImagesFolder()
        {
            // Add The Image In New Folder with New Path Using guid To Make the Image Unique

            if (!string.IsNullOrEmpty(ImagePath))
            {
                if (OldImagePath != ImagePath)
                {
                    if(File.Exists(OldImagePath))
                    {
                        File.Delete(OldImagePath);
                    }

                    //1 This Is The Path From OpenFileDialog
                    string SourcePath = ImagePath;

                    //2 This is the Path Of folder To save in it.
                    string PeopleImages = @"D:\C#\19 Full Real Project\People Images";

                    //3 To get an extension like ( .jpg )
                    string extension = Path.GetExtension(SourcePath);

                    //4 New Image name Using Guid
                    string newImageName = Guid.NewGuid().ToString() + extension;

                    //5 Final destinations
                    string destinationPath = Path.Combine(PeopleImages, newImageName);

                    //6 Image Copy
                    File.Copy(SourcePath, destinationPath, true);

                    //7 To Database
                    ImagePath = destinationPath;
                    return true;
                }
                return true;
            }
            return false;
        }


        // Remove Image
        private void lnkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(rbtnMale.Checked)
            {
                picboxImage.Image = Resources.person_man;
            }
            else
            {
                picboxImage.Image = Resources.person_woman;
            }           
        }


        // Save And Close Button Using Delegate
        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseClicked?.Invoke(this, EventArgs.Empty);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!IsAllInfoCompleted())
            {
                MessageBox.Show("You Must Enter All Requirements Of Information!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            SaveClicked?.Invoke(this, EventArgs.Empty);
        }


    

    }
}
