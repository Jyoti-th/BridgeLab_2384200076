using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Keyword_Level_1
{
    internal class CallingAllClass
    {

        public void CallingBankAccount()
        {
            BankAccount obj = new BankAccount(101, "Jyoti Thakur", 10000);
            BankAccount.BankOperations(obj);

        }
        public void CallingLibrary()
        {
            LibraryManagementSystem.DisplayLibraryName();

            // Creating book objects
            LibraryManagementSystem book1 = new LibraryManagementSystem("C# Programming", "John Doe", "123-456-789");
            LibraryManagementSystem book2 = new LibraryManagementSystem("Data Structures", "Jane Smith", "987-654-321");

            // Displaying book details
            book1.DisplayBookDetails();
            book2.DisplayBookDetails();
        }

        public void CallingEmployee()
        {
            // Creating employee objects
            EmployeeManagementSystem emp1 = new EmployeeManagementSystem("Alice Johnson", 101, "Software Engineer");
            EmployeeManagementSystem emp2 = new EmployeeManagementSystem("Bob Smith", 102, "Project Manager");

            // Display total employees
            EmployeeManagementSystem.DisplayTotalEmployees();

            // Displaying employee details
            emp1.DisplayEmployeeDetails();
            emp2.DisplayEmployeeDetails();
        }

        public void CallingShoppingCart()
        {
            // Updating discount for all products
            ShoppingCartSystem.UpdateDiscount(15.0);

            // Creating product objects
            ShoppingCartSystem product1 = new ShoppingCartSystem(101, "Laptop", 1200.00, 2);
            ShoppingCartSystem product2 = new ShoppingCartSystem(102, "Smartphone", 800.00, 5);

            // Displaying product details
            product1.DisplayProductDetails();
            product2.DisplayProductDetails();
        }

        public void CallingUniversity()
        {
            // Display total students before enrollment
            UniversityStudentManagement.DisplayTotalStudents();

            // Creating student objects
            UniversityStudentManagement student1 = new UniversityStudentManagement("Aashutosh", 101, 'A');
            UniversityStudentManagement student2 = new UniversityStudentManagement("Ankit", 102, 'B');

            // Display total students after enrollment
            UniversityStudentManagement.DisplayTotalStudents();

            // Displaying student details
            student1.DisplayStudentDetails();
            student2.DisplayStudentDetails();

            // Updating student grade
            student2.UpdateGrade('A');

            // Display updated details
            student2.DisplayStudentDetails();
        }

        public void CallingVehicle()
        {
            // Updating the registration fee
            VehicleRegistrationSystem.UpdateRegistrationFee(550.00);

            // Creating vehicle objects
            VehicleRegistrationSystem vehicle1 = new VehicleRegistrationSystem("Alice Johnson", "Car", "ABC123");
            VehicleRegistrationSystem vehicle2 = new VehicleRegistrationSystem("Bob Smith", "Motorcycle", "XYZ789");

            // Displaying vehicle details
            vehicle1.DisplayVehicleDetails();
            vehicle2.DisplayVehicleDetails();
        }

        public void CallingHospital()
        {

            // Display total patients before admitting any
            HospitalManagementSystem.GetTotalPatients();

            // Creating patient objects
            HospitalManagementSystem patient1 = new HospitalManagementSystem(101, "Aashutosh", 30, "Flu");
            HospitalManagementSystem patient2 = new HospitalManagementSystem(102, "Ankit", 45, "Fever");

            // Display total patients after admission
            HospitalManagementSystem.GetTotalPatients();

            // Displaying patient details
            patient1.DisplayPatientDetails();
            patient2.DisplayPatientDetails();
        }
    }
}
