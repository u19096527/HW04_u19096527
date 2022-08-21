using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW04_u19096527.Models;

namespace HW04_u19096527.Controllers
{
    public class HomeController : Controller
    {
        //DECLARE CLIENT USERS
        public static List<Client> Clients = new List<Client>();

        //DECLARE PROFESSIONAL USERS
        public static List<Professional> Professionals = new List<Professional>();

        /*        
         
         
         
         
         
         
        084 776 3100 
        085 506 3078 
        084 841 4194 
        083 644 5612 
        083 618 9524 
        082 904 8545 
        084 653 4468 
        083 798 4919 
        082 946 2495 
        082 518 5124 
        085 688 6197 */
        //INITIALISE OBJ DATA TO AVOID ERROR
        private void InitialiseStorage()
        {
            //if list "Users" is empty then populate with following
            if (Users.Count() == 0)
            {
                Clients.Add(new Client(1,"Kara","Danvers", "084 351 1653", "kara.danvers@gmail.com","Kara123", "Ms.", "31-05-1995"));
                Clients.Add(new Client(2, "Barry", "Allen", "082 944 9497", "barry.allen@yahoo.com", "Barry123", "Mr.", "27-08-1971"));
                Clients.Add(new Client(3, "Oliver", "Queen", "082 297 4942", "oliver.queen@hotmail.com", "Oliver123", "Mr.", "30-09-1983"));

                //        public Client(string Title, string DOB, int ID, string Name, string Surname, string CellNumber, string Email, string Password) : base(ID, Name, Surname, CellNumber, Email, Password)

                //public Professional(int ID, string Name, string Surname, string CellNumber, string Email, string Password, string OrgStructure, int NumOfEmployees, string BusinessName):base( ID,  Name,  Surname,  CellNumber,  Email, Password)
                Professionals.Add(new Professional(1,"Tony","Stark", "014 778 9268", "tony@starkindustries.com","123Stark","Small Business",236,"Stark Industries"));
                Professionals.Add(new Professional(2, "Natasha", "Romanoff", "014 901 9647", "natasha@blackwidowsecurity.com", "123Romanoff", "Small Business", 80, "Black Widow Security"));
                Professionals.Add(new Professional(3, "Steve", "Rogers", "013 653 2698", "steve@brooklynplumbing.com", "123Rogers", "Micro Business", 5, "Brooklyn Plumbing Solutions"));

                // populaate user account list
                Users.AddRange(Clients);
                Users.AddRange(Professionals);
            }

        }
        public static List<User> Users = new List<User>();


        public ActionResult Index()
        {
            InitialiseStorage();
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }

 

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}