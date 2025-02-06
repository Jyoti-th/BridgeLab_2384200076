using System;
using System.Collections.Generic;

namespace OOPs_Object_Modeling
{
    public class Faculty
    {
        public string FacultyName { get; set; }
        public string Specialization { get; set; }

        public Faculty(string name, string specialization)
        {
            FacultyName = name;
            Specialization = specialization;
        }

        public override string ToString()
        {
            return $"{FacultyName}, Specialization: {Specialization}";
        }
    }

    // ✅ Department ka naam change karke FacultyDepartment rakha
    public class FacultyDepartment
    {
        public string DepartmentName { get; set; }
        public List<Faculty> Faculties { get; set; }

        public FacultyDepartment(string name)
        {
            DepartmentName = name;
            Faculties = new List<Faculty>();
        }

        // Add a faculty member to the department
        public void AddFaculty(Faculty faculty)
        {
            Faculties.Add(faculty);
        }

        // Display all faculty members in the department
        public void DisplayFaculties()
        {
            Console.WriteLine($"Department: {DepartmentName}");
            if (Faculties.Count == 0)
            {
                Console.WriteLine("No faculty members in this department.");
            }
            else
            {
                foreach (var faculty in Faculties)
                {
                    Console.WriteLine($"- {faculty}");
                }
            }
        }
    }

    public class University
    {
        public string UniversityName { get; set; }
        public List<FacultyDepartment> Departments { get; set; }  

        public University(string name)
        {
            UniversityName = name;
            Departments = new List<FacultyDepartment>(); 
        }

        public void AddDepartment(FacultyDepartment department) 
        {
            Departments.Add(department);
        }

        public void DisplayDepartments()
        {
            Console.WriteLine($"University: {UniversityName}");
            if (Departments.Count == 0)
            {
                Console.WriteLine("No departments in this university.");
            }
            else
            {
                foreach (var department in Departments)
                {
                    department.DisplayFaculties();
                }
            }
        }

        public void DeleteUniversity()
        {
            Console.WriteLine($"University {UniversityName} is being deleted...");
            Departments.Clear();
        }
    }
}
