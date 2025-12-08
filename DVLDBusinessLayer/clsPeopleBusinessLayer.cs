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
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        clsPeopleBusinessLayer(int PersonID, int NationalNO, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, string Gender, string Address, string Phone, string Email)
        {
            this.PersonID = PersonID;
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

    }
}
