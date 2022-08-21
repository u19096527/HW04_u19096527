using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW04_u19096527.Models;
using HW04_u19096527.Controllers;

namespace HW04_u19096527.Controllers
{
    public class HomeController : Controller
    {
        //DECLARE CLIENT USERS
        public static List<Client> Clients = new List<Client>();

        //DECLARE PROFESSIONAL USERS
        public static List<Professional> Professionals = new List<Professional>();

        //DECLARE JOB POST LIST
        public static List<JobPost> currentJobPosts = new List<JobPost>();



        /*        

         Clients.Add(new Client("C1","Kara","Danvers", "084 351 1653", "kara.danvers@gmail.com","Kara123", "Ms.", "31-05-1995"));
         
         
         
         
         
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
                Clients.Add(new Client("C1","Kara","Danvers", "084 351 1653", "kara.danvers@gmail.com","Kara123", "Ms.", "31-05-1995"));
                Clients.Add(new Client("C2", "Barry", "Allen", "082 944 9497", "barry.allen@yahoo.com", "Barry123", "Mr.", "27-08-1971"));
                Clients.Add(new Client("C3", "Oliver", "Queen", "082 297 4942", "oliver.queen@hotmail.com", "Oliver123", "Mr.", "30-09-1983"));

                Professionals.Add(new Professional("P1","Tony","Stark", "014 778 9268", "tony@starkindustries.com","123Stark","Small Business",236,"Stark Industries"));
                Professionals.Add(new Professional("P2", "Natasha", "Romanoff", "014 901 9647", "natasha@blackwidowsecurity.com", "123Romanoff", "Small Business", 80, "Black Widow Security"));
                Professionals.Add(new Professional("P3", "Steve", "Rogers", "013 653 2698", "steve@brooklynplumbing.com", "123Rogers", "Micro Business", 5, "Brooklyn Plumbing Solutions"));

                // populate user account list
                Users.AddRange(Clients);
                Users.AddRange(Professionals);
            }
            //public JobPost(string JobPostID, string FieldType, string Description, string Location, string DueDate, string Status, string JobType, string JobTerm, int NumOfWorkers)

            //if list jobPosts is empty then populate with the foollowing
            if (currentJobPosts.Count() == 0)
            {
                currentJobPosts.Add(new JobPost("JB1","Plumbing","Toilet has been leaking for 3 days from the cistern tank. New shower door and basin needs to be installed.","Pretoria","23-08-2022","Incomplete","Domestic","Short-Term",2));
                currentJobPosts.Add(new JobPost("JB2", "Construction", "Government to build public toilets for schools in rural areas. Experience with brick-laying or plumbing is needed", "Soshanguve", "31-08-2022", "Incomplete", "Non-Domestic", "Long-Term", 15));
                currentJobPosts.Add(new JobPost("JB3", "Gardening", "New gardener wanted. Experience with decorative bush cutting. If job done well, you can get a permanent job as regular gardener", "Polokwane", "03-09-2022", "Incomplete", "Domestic", "Short-Term", 1));

            }

        }
        public static List<User> Users = new List<User>();


        public ActionResult Index()
        {
            InitialiseStorage();
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