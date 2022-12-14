using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW04_u19096527.Models;
using HW04_u19096527.Controllers;

namespace HW04_u19096527.Controllers
{
    public class ClientController : Controller
    {
        //DECLARE CLIENT USERS
        public static List<Client> Clients = new List<Client>();

        //DECLARE JOB POST LIST
        public static List<JobPost> currentJobPosts = new List<JobPost>();


        // GET: Client
        private void InitialiseClients()
        {
            //if list "Users" is empty then populate with following
            if (Clients.Count() == 0)
            {
                Clients.Add(new Client("C1", "Kara", "Danvers", "084 351 1653", "kara.danvers@gmail.com", "Kara123", "Ms.", "31-05-1995"));
                Clients.Add(new Client("C2", "Barry", "Allen", "082 944 9497", "barry.allen@yahoo.com", "Barry123", "Mr.", "27-08-1971"));
                Clients.Add(new Client("C3", "Oliver", "Queen", "082 297 4942", "oliver.queen@hotmail.com", "Oliver123", "Mr.", "30-09-1983"));

            }
            //if list jobPosts is empty then populate with the foollowing
            if (currentJobPosts.Count() == 0)
            {
                currentJobPosts.Add(new JobPost("JB1", "Plumbing", "Toilet has been leaking for 3 days from the cistern tank. New shower door and basin needs to be installed.", "Pretoria", "23-08-2022", "Incomplete", "Domestic", "Short-Term", 2));
                currentJobPosts.Add(new JobPost("JB2", "Construction", "Government to build public toilets for schools in rural areas. Experience with brick-laying or plumbing is needed", "Soshanguve", "31-08-2022", "Incomplete", "Non-Domestic", "Long-Term", 15));
                currentJobPosts.Add(new JobPost("JB3", "Gardening", "New gardener wanted. Experience with decorative bush cutting. If job done well, you can get a permanent job as regular gardener", "Polokwane", "03-09-2022", "Incomplete", "Domestic", "Short-Term", 1));

            }
        }
            public ActionResult Index()
        {
            InitialiseClients();
            //my client user account
            return View();
        }
        public ActionResult CreateClient()
        {
            InitialiseClients();

            return View();
        }

        public ActionResult AddJobPost()
        {
            InitialiseClients();

            return View();
        }

    }
}