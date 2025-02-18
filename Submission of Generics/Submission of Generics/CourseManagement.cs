using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Generics
{
    public abstract class CourseType
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }

        public CourseType(string courseName, int credits)
        {
            CourseName = courseName;
            Credits = credits;
        }
        public abstract void DisplayEvaluation();
    }

    public class ExamCourse : CourseType
    {
        public ExamCourse(string courseName, int credits) : base(courseName, credits) { }

        public override void DisplayEvaluation()
        {
            Console.WriteLine($"{CourseName} evaluated through final exams.");
        }

    }

    public class AssignmentCourse : CourseType
    {
        public AssignmentCourse(string courseName, int credits) : base(courseName, credits) { }

        public override void DisplayEvaluation()
        {
            Console.WriteLine($"{CourseName} evaluated through Assignment exams.");
        }
    }

    public class Course<T> where T : CourseType
    {
        private List<T> courseList = new List<T>();

        public void Add(T course)
        {
            courseList.Add(course);
            Console.WriteLine($"{course.CourseName} added to the course list.");
        }

        public void DisplayAllCourses()
        {
            Console.WriteLine("\n--- University Courses ---");
            foreach (var course in courseList)
            {
                Console.WriteLine($"Course : {course.CourseName}, Credits : {course.Credits}");
                course.DisplayEvaluation();
            }
            Console.WriteLine("-----------------------------\n");
        }
    }
}
