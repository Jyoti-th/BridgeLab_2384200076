using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Object_Modeling
{
    internal class CallingAllClasses
    {
        public void CallingLibrary()
        {
            //create books
            Book book1 = new Book("The Hidden Hindu", "Akshat Gupta");
            Book book2 = new Book("Atomic Habit", "James Clear");
            Book book3 = new Book("Mindset", "Carol dweck");
            Book book4 = new Book("The Secret", "Rhonda byrne");

            //create libraries
            Library library1 = new Library("City Library");
            Library library2 = new Library("University Library");

            //add books to the different libraries
            library1.AddBook(book1);
            library1.AddBook(book2);
            library2.AddBook(book2);
            library2.AddBook(book3);
            library2.AddBook(book4);

            //display
            library1.DisplayLibrary();
            library2.DisplayLibrary();
        }

        public void CallingBankAccount()
        {
            Bank myBank = new Bank("National Bank");
            Customer customer1 = new Customer("Alice");

            myBank.OpenAccount(customer1, "Savings", 1000);
            myBank.OpenAccount(customer1, "Checking", 500);

            customer1.ViewBalance();
        }

        public void CallingEmployee() 
        {
            // Create employees
            Employee emp1 = new Employee("sahil", "Software Engineer");
            Employee emp2 = new Employee("prabhat", "HR Manager");
            Employee emp3 = new Employee("chandra", "Sales Executive");

            // Create departments
            Department devDepartment = new Department("Development");
            Department hrDepartment = new Department("Sales");

            // Add employees to departments
            devDepartment.AddEmployee(emp1);
            hrDepartment.AddEmployee(emp2);
            hrDepartment.AddEmployee(emp3);

            // Create company
            Company company = new Company("Bridge labz");

            // Add departments to the company
            company.AddDepartment(devDepartment);
            company.AddDepartment(hrDepartment);

            // Display company structure before deletion
            company.DisplayCompanyStructure();

            // Delete the company (this will also delete all departments and employees)
            company.DeleteCompany();

            // Attempt to display company structure after deletion
            company.DisplayCompanyStructure();

        }
        public void CallingCourse()
        {
            // Create a school
            School school = new School("Delhi public School");

            // Create some students
            Student student1 = new Student("Vishal");
            Student student2 = new Student("Vijay");

            // Add students to the school
            school.AddStudent(student1);
            school.AddStudent(student2);

            // Create some courses
            Course course1 = new Course("Mathematics");
            Course course2 = new Course("Science");

            // Enroll students in courses
            course1.EnrollStudent(student1);
            course1.EnrollStudent(student2);
            course2.EnrollStudent(student1);

            // Show the enrolled courses for each student
            student1.ShowEnrolledCourses();
            student2.ShowEnrolledCourses();

            // Show the students enrolled in each course
            course1.ShowEnrolledStudents();
            course2.ShowEnrolledStudents();

            // Show all students in the school
            school.ShowAllStudents();
        }

        public void CallingFaculty()
        {
            // Create faculty members
            Faculty faculty1 = new Faculty("Rohit", "Computer Science");
            Faculty faculty2 = new Faculty("Avdesh", "Physics");
            Faculty faculty3 = new Faculty("Suneel", "Mathematics");

            // Create departments (Updated: Changed Department to FacultyDepartment)
            FacultyDepartment csDepartment = new FacultyDepartment("Computer Science");
            FacultyDepartment physicsDepartment = new FacultyDepartment("Physics");

            // Add faculty to departments
            csDepartment.AddFaculty(faculty1);
            physicsDepartment.AddFaculty(faculty2);
            physicsDepartment.AddFaculty(faculty3);

            // Create university
            University university = new University("GLA University");

            // Add departments to the university
            university.AddDepartment(csDepartment);
            university.AddDepartment(physicsDepartment);

            // Display departments and faculty members before university deletion
            university.DisplayDepartments();

            // Demonstrate that faculty can exist independently of a department
            Console.WriteLine("\nFaculty members independent of departments:");
            Console.WriteLine(faculty1); // Faculty member can exist outside any department
            Console.WriteLine(faculty2);

            // Delete the university (and its departments)
            university.DeleteUniversity();

            // Show that the departments are deleted
            university.DisplayDepartments();
        }

        public void CallingPatientHospital()
        {
            // Create the hospital
            Hospital hospital = new Hospital("Delhi AIIMS");

            // Create doctors
            Doctor doctor1 = new Doctor("Dr. Pranjal", "Surgery");
            Doctor doctor2 = new Doctor("Dr. Vijay", "Ortho");

            // Add doctors to the hospital
            hospital.AddDoctor(doctor1);
            hospital.AddDoctor(doctor2);

            // Create patients
            Patient patient1 = new Patient("Vaibhav");
            Patient patient2 = new Patient("Ankit");

            // Add patients to the hospital
            hospital.AddPatient(patient1);
            hospital.AddPatient(patient2);

            // Patients consult with doctors
            patient1.ConsultWithDoctor(doctor1);
            patient2.ConsultWithDoctor(doctor1);
            patient1.ConsultWithDoctor(doctor2);

            // Show the patients consulted by each doctor
            doctor1.ShowPatients();
            doctor2.ShowPatients();

            // Show the list of all doctors and patients in the hospital
            hospital.ShowHospitalDetails();
        }

        public void CallingEcommerce()
        {
            // Creating products
            Product product1 = new Product("Laptop", 1000);
            Product product2 = new Product("Smartphone", 800);
            Product product3 = new Product("Headphones", 150);

            // Creating first order
            Order order1 = new Order("ORD123");
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            // Creating customer
            EcommerceCustomer customer1 = new EcommerceCustomer("John Doe", "john@example.com");

            // Customer places first order
            customer1.PlaceOrder(order1);

            // Creating second order
            Order order2 = new Order("ORD124");
            order2.AddProduct(product3);

            // Customer places second order
            customer1.PlaceOrder(order2);

            // Display customer's orders and details
            customer1.DisplayCustomerOrders();
        }

        public void CallingUniversityManagement()
        {
            // Create professors
            UniversityProfessor professor1 = new UniversityProfessor("Rohit");
            UniversityProfessor professor2 = new UniversityProfessor("Sachendra");

            // Create courses
            UniversityCourse course1 = new UniversityCourse("Python");
            UniversityCourse course2 = new UniversityCourse("Java");
            UniversityCourse course3 = new UniversityCourse("C#");

            // Assign professors to courses
            professor1.AssignProfessor(course1);
            professor2.AssignProfessor(course2);

            // Create students
            UniversityStudent student1 = new UniversityStudent("Yugal");
            UniversityStudent student2 = new UniversityStudent("Vijay");
            UniversityStudent student3 = new UniversityStudent("Vaibhav");

            // Students enroll in courses
            student1.EnrollCourse(course1);
            student1.EnrollCourse(course2);
            student2.EnrollCourse(course1);
            student3.EnrollCourse(course2);
            student3.EnrollCourse(course3);
        }
    }
}
