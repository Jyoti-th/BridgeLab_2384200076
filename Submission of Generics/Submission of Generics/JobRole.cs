using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Generics
{

        public abstract class JobRole
        {
            public abstract string RoleName { get; }
        }

        public class SoftwareEngineer : JobRole
        {
            public override string RoleName => "Software Engineer";
        }

        public class DataScientist : JobRole
        {
            public override string RoleName => "Data Scientist";
        }

        public class Resume<T> where T : JobRole
        {
            public string CandidateName { get; set; }
            public int ExperienceYears { get; set; }
            public T JobPosition { get; set; }

            public Resume(string candidateName, int experienceYears, T jobPosition)
            {
                CandidateName = candidateName;
                ExperienceYears = experienceYears;
                JobPosition = jobPosition;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Candidate: {CandidateName}, Experience: {ExperienceYears} years, Applying for: {JobPosition.RoleName}");
            }
        }
        public class ResumeScreening
        {
            private List<object> screeningPipeline = new List<object>();

            public void AddResume<T>(Resume<T> resume) where T : JobRole
            {
                screeningPipeline.Add(resume);
                Console.WriteLine($"Added {resume.CandidateName}'s resume for {resume.JobPosition.RoleName}.");
            }

            public void DisplayScreeningResults()
            {
                Console.WriteLine("\nScreening Pipeline Results:");
                foreach (var resume in screeningPipeline)
                {
                    if (resume is Resume<JobRole> r)
                    {
                        r.DisplayInfo();
                    }
                }
            }
        }
    }

