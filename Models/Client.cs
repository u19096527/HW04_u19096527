using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW04_u19096527.Models;

namespace HW04_u19096527.Models
{
    public class Client : User
    {
        //DATA MEMBERS
        public string mTitle;
        public string mDOB;

        //DEFAULT CONSTRUCTORS
        public Client(string ID, string Name, string Surname, string CellNumber, string Email, string Password, string Title, string DOB) : base(ID, Name, Surname, CellNumber, Email, Password)
        {
            mTitle = Title;
            mDOB = DOB;
        }
        public Client() : base()
        {

        }

        //METHODS

        //PROPERTIES
        public string Title
        {
            get { return mTitle; }
            set { mTitle = value; }
        }
        public string DOB
        {
            get { return mDOB; }
            set { mDOB = value; }
        }

    }
}

