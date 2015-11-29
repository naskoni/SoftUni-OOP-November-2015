using _3.CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompanyHierarchy
{
    class Project : IProject
    {
        private const string ProjectNameErrorMessage = "The field Project name cannot be empty!";
        private const string DetailsErrorMessage = "The field Details cannot be empty!";

        private string projectName;
        private string details;
        private State state;

        public Project(string projectName, DateTime projectStartDate,
            string details)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = State.Open;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ProjectNameErrorMessage);
                }
                this.projectName = value;
            }
        }

        public DateTime ProjectStartDate { get; set; }        

        public string Details
        {
            get { return this.details; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(DetailsErrorMessage);
                }
                this.details = value;
            }
        }

        public State State
        {
            get { return this.state; } 

            private set
            {
                this.State = value;
            }   
        }

        public void CloseProject()
        {
            this.state = State.Closed;
        }

        public override string ToString()
        {
            return $"{this.ProjectName}, start date: {this.ProjectStartDate}, state: {this.State}";
        }
    }
}
