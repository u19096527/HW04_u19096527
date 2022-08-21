using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW04_u19096527.Models;
using HW04_u19096527.Controllers;

namespace HW04_u19096527.Controllers
{
    public class ProController : Controller
    {
        //DECLARE PROFESSIONAL USERS
        public static List<Professional> Professionals = new List<Professional>();

        public static List<JobPost> currentJobPosts = new List<JobPost>();

        private void InitialiseProfessionals()
        {
            //if list "Users" is empty then populate with following
            if (Professionals.Count() == 0)
            {
                Professionals.Add(new Professional("P1", "Tony", "Stark", "014 778 9268", "tony@starkindustries.com", "123Stark", "Small Business", 236, "Stark Industries"));
                Professionals.Add(new Professional("P2", "Natasha", "Romanoff", "014 901 9647", "natasha@blackwidowsecurity.com", "123Romanoff", "Small Business", 80, "Black Widow Security"));
                Professionals.Add(new Professional("P3", "Steve", "Rogers", "013 653 2698", "steve@brooklynplumbing.com", "123Rogers", "Micro Business", 5, "Brooklyn Plumbing Solutions"));
            }

            if (currentJobPosts.Count() == 0)
            {
                currentJobPosts.Add(new JobPost("JB1", "Plumbing", "Toilet has been leaking for 3 days from the cistern tank. New shower door and basin needs to be installed.", "Pretoria", "23-08-2022", "Incomplete", "Domestic", "Short-Term", 2));
                currentJobPosts.Add(new JobPost("JB2", "Construction", "Government to build public toilets for schools in rural areas. Experience with brick-laying or plumbing is needed", "Soshanguve", "31-08-2022", "Incomplete", "Non-Domestic", "Long-Term", 15));
                currentJobPosts.Add(new JobPost("JB3", "Gardening", "New gardener wanted. Experience with decorative bush cutting. If job done well, you can get a permanent job as regular gardener", "Polokwane", "03-09-2022", "Incomplete", "Domestic", "Short-Term", 1));

            }
        }



            // GET: Pro
            public ActionResult Index()
        {
            InitialiseProfessionals();
            //my professional user account details
            return View();
        }

        public ActionResult CreatePro()
        {
            InitialiseProfessionals();

            return View();
        }

        public ActionResult ViewJobPosts()
        {
            InitialiseProfessionals();

            return View();
        }
    }
}