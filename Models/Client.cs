using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW04_u19096527.Models;

namespace HW04_u19096527.Models
{
    public class Client : User
    {
        public Client(int ID, string Name, string Surname, string CellNumber, string Email, string Password) : base(ID, Name, Surname, CellNumber, Email, Password)
        {

        }
        public Client() : base()
        {

        }
    }
}

