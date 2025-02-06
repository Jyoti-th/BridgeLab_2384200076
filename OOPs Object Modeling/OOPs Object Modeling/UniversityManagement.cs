using System;
using System.Collections.Generic;

namespace OOPs_Object_Modeling
{
    // Define the UniversityStudent class (Renamed from Student)
    class UniversityStudent
    {
        public string StudentName { get; set; }
        public List<UniversityCourse> EnrolledCourses { get; set; }

        public UniversityStudent(string name)
        {
            StudentName = name;
            EnrolledCourses = new List<UniversityCourse>();
        }

        public void EnrollCourse(UniversityCourse course)
        {
            if (!EnrolledCourses.Contains(course))
            {
                EnrolledCourses.Add(course);
                course.AddStudent(this);
                Console.WriteLine($"{StudentName} has enrolled in {course.CourseName}");
            }
        }
    }

    // Define the UniversityProfessor class (Renamed from Professor)
    class UniversityProfessor
    {
        public string ProfessorName { get; set; }
        public List<UniversityCourse> TaughtCourses { get; set; }

        public UniversityProfessor(string name)
        {
            ProfessorName = name;
            TaughtCourses = new List<UniversityCourse>();
        }

        public void AssignProfessor(UniversityCourse course)
        {
            if (!TaughtCourses.Contains(course))
            {
                TaughtCourses.Add(course);
                course.Professor = this;
                Console.WriteLine($"{ProfessorName} is assigned to teach {course.CourseName}");
            }
        }
    }

    // Define the UniversityCourse class (Renamed from Course)
    class UniversityCourse
    {
        public string CourseName { get; set; }
        public UniversityProfessor Professor { get; set; }
        public List<UniversityStudent> EnrolledStudents { get; set; }

        public UniversityCourse(string courseName)
        {
            CourseName = courseName;
            EnrolledStudents = new List<UniversityStudent>();
        }

        public void AddStudent(UniversityStudent student)
        {
            if (!EnrolledStudents.Contains(student))
            {
                EnrolledStudents.Add(student);
                Console.WriteLine($"{student.StudentName} is added to the course {CourseName}");
            }
        }
    }

   
}
