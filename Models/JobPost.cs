using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04_u19096527.Models
{
    public class JobPost
    {
        //DATA MEMBERS
        private string mJobPostID;
        private string mFieldType;
        private string mDescription;
        private string mLocation;
        private string mDueDate;
        private string mStatus;
        private string mJobType;
        private string mJobTerm;
        private int mNumOfWorkers;

        //DEFAULT CONSTRUCTORS

        public JobPost()
        {

        }
        public JobPost(string JobPostID, string FieldType, string Description, string Location, string DueDate, string Status, string JobType, string JobTerm, int NumOfWorkers)
        {
            this.mJobPostID = JobPostID;
            this.mFieldType = FieldType;
            this.mDescription = Description;
            this.mLocation = Location;
            this.mDueDate = DueDate;
            this.mStatus = Status;
            this.mJobType = JobType;
            this.mJobTerm = JobTerm;
            this.mNumOfWorkers = NumOfWorkers;
        }


        //METHODS

        //PROPERTIES
        public string JobPostID { get => mJobPostID; set => mJobPostID = value; }
        public string FieldType { get => mFieldType; set => mFieldType = value; }
        public string Description { get => mDescription; set => mDescription = value; }
        public string Location { get => mLocation; set => mLocation = value; }
        public string DueDate { get => mDueDate; set => mDueDate = value; }
        public string Status { get => mStatus; set => mStatus = value; }
        public string JobType { get => mJobType; set => mJobType = value; }
        public string JobTerm { get => mJobTerm; set => mJobTerm = value; }
        public int NumOfWorkers { get => mNumOfWorkers; set => mNumOfWorkers = value; }

        /*        Pro id
        Client id
        Field type
        Description
        Location
        Client review
        Pro review
        Date created
        Date completed
        Domestic / non domestic?
        Short term / long term
        Number of workers*/
    }
}