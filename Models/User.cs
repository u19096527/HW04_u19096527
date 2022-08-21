using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04_u19096527.Models
{
    public class User
    {
        //DATA MEMBERS
        public int mID;
        public string mName;
        public string mSurname;
        public string mCellNumber;
        public string mEmail;
        public string mPassword;

        //PROPERTIES
        public int ID { get => mID; set => mID = value; }
        public string Name { get => mName; set => mName = value; }
        public string Surname { get => mSurname; set => mSurname = value; }
        public string CellNumber { get => mCellNumber; set => mCellNumber = value; }
        public string Email { get => mEmail; set => mEmail = value; }
        public string Password { get => mPassword; set => mPassword = value; }

        //DEFAULT CONSTRUCTORS
        public User()
        {

        }

        public User(int ID, string Name, string Surname, string CellNumber, string Email, string Password)
        {
            mID = ID;
            mName = Name;
            mSurname = Surname;
            mCellNumber = CellNumber;
            mEmail = Email;
            mPassword = Password;
        }
    }
    //METHODS


}