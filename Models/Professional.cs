using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04_u19096527.Models
{
    public class Professional : User
    {
        //DATA MEMBERS
        public string mOrgStructure;
        public int mNumOfEmployees;
        public string mBusinessName;

        //DEFAULT CONSTRUCTORS
        public Professional():base()
        {

        }

        public Professional(string ID, string Name, string Surname, string CellNumber, string Email, string Password, string OrgStructure, int NumOfEmployees, string BusinessName):base( ID,  Name,  Surname,  CellNumber,  Email, Password)
        {
            mOrgStructure = OrgStructure;
            mNumOfEmployees = NumOfEmployees;
            mBusinessName = BusinessName;
        }

        //METHODS

        //PROPERTIES
        public string OrgStructure {
            get { return mOrgStructure; }
            set { mOrgStructure = value; }
        }
        public int NumOfEmployees {
            get { return mNumOfEmployees; }
            set { mNumOfEmployees = value; }
        }
        public string BusinessName {
            get { return mBusinessName; }
            set { mBusinessName = value; }
        }
    }
}