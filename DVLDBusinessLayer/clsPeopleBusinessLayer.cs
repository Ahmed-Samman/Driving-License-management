using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsPeopleBusinessLayer
    {
        public enum enMode { AddMode = 0, UpdateMode = 1 };
        enMode Mode = enMode.UpdateMode;


        public int PersonID { get; set; }
        public string NationalNO { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }


        public clsPeopleBusinessLayer()
        {
            this.PersonID = -1;
            this.NationalNO = "";
            this.NationalityCountryID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = 0;
            this.Phone = "";
            this.Email = "";
            this.ImagePath = "";
            Mode = enMode.AddMode;
        }

        clsPeopleBusinessLayer(int PersonID, string NationalNO, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email, int CountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNO = NationalNO;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = CountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.UpdateMode;
        }


        static public DataTable List()
        {
            return clsPeopleDataAccess.GetAllTable();
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPeopleDataAccess.AddNewPerson(NationalNO, FirstName, SecondName, 
                ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
           return clsPeopleDataAccess.UpdatePerson(PersonID, NationalNO, FirstName, SecondName, ThirdName, LastName,
                DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

        }

        static public bool Search_NationalNO(string National_NO)
        {
             return clsPeopleDataAccess.IsNationalNO_Exist(National_NO);
        }

        static public bool IsDeleted(int PersonID)
        {
            return clsPeopleDataAccess.DeletePerson(PersonID);
        }

        static public clsPeopleBusinessLayer FindPersonInfoByID(int PersonID)
        {
            string NationalNO = string.Empty, FirstName = string.Empty, 
                SecondName = string.Empty, ThirdName = string.Empty, 
                LastName = string.Empty, Address = string.Empty, Phone = string.Empty, 
                Email = string.Empty, ImagePath = string.Empty;
            int CountryID = -1;
            byte Gender = 0;
            DateTime DateOfBirth = DateTime.Now;
           
            if(clsPeopleDataAccess.FindPersonByID(PersonID, ref NationalNO, ref FirstName, ref SecondName, ref ThirdName, ref LastName, 
                ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref CountryID, ref ImagePath))
            {
                return new clsPeopleBusinessLayer(PersonID, NationalNO, FirstName, SecondName,
             ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, CountryID, ImagePath);
                
            }
            else
            {
                return null;
            }  
        }

        static public DataTable GetAllCountries()
        {
            return clsCountryDataAccess.GetAllCountries_FromDatabase();
        }
       

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddMode:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    break;

                    case enMode.UpdateMode:
                    if (_UpdatePerson())
                    {
                        Mode = enMode.AddMode;
                        return true;
                    }
                    break;
                              
            }

            return false;

        }
    }
}
