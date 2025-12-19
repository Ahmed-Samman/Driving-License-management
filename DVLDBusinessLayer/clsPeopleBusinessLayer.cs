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
        public int NationalityCountryID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
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

        clsPeopleBusinessLayer(int PersonID, string NationalNO, int CountryID, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email)
        {
            this.PersonID = PersonID;
            this.NationalNO = NationalNO;
            this.NationalityCountryID = CountryID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
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

        static public bool Search_NationalNO(string National_NO)
        {
             return clsPeopleDataAccess.IsNationalNO_Exist(National_NO);
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
                    
                //case enMode.UpdateMode:
                //    {

                //    }           
            }

            return false;

        }
    }
}
