using System;
using System.Collections.Generic;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsPeopleBusinessLayer
    {
        public int PersonID { get; set; }
        public int NationalNO { get; set; }
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


        clsPeopleBusinessLayer(int PersonID, int NationalNO, int CountryID, string FirstName, string SecondName,
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
            return (this.PersonID == -1);
        }



    }
}
