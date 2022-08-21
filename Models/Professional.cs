using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04_u19096527.Models
{
    public class Professional : User
    {
        public Professional():base()
        {

        }

        public Professional(int ID, string Name, string Surname, string CellNumber, string Email, string Password):base( ID,  Name,  Surname,  CellNumber,  Email, Password)
        {

        }
    }
}