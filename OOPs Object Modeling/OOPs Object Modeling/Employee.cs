using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Object_Modeling
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string Position { get; set; }

        public Employee(string name, string position)
        {
            EmployeeName = name;
            Position = position;
        }

        public override string ToString()
        {
            return $"{EmployeeName} - {Position}";
        }
    }

    // Define the Department class
    class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
            Employees = new List<Employee>();
        }

        // Add an employee to the department
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        // Display all employees in the department
        public void DisplayEmployees()
        {
            Console.WriteLine($"Department: {DepartmentName}");
            if (Employees.Count == 0)
            {
                Console.WriteLine("No employees in this department.");
            }
            else
            {
                foreach (var employee in Employees)
                {
                    Console.WriteLine($"- {employee}");
                }
            }
        }
    }

    // Define the Company class
    class Company
    {
        public string CompanyName { get; set; }
        public List<Department> Departments { get; set; }

        public Company(string companyName)
        {
            CompanyName = companyName;
            Departments = new List<Department>();
        }

        // Add a department to the company
        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

        // Display all departments and employees in the company
        public void DisplayCompanyStructure()
        {
            Console.WriteLine($"Company: {CompanyName}");
            if (Departments.Count == 0)
            {
                Console.WriteLine("No departments in this company.");
            }
            else
            {
                foreach (var department in Departments)
                {
                    department.DisplayEmployees();
                }
            }
        }

        // Simulate deletion of the company and all its departments and employees
        public void DeleteCompany()
        {
            Console.WriteLine($"Company {CompanyName} is being deleted...");
            Departments.Clear(); // All departments (and employees) are deleted when the company is deleted
        }
    }

    
        

}

