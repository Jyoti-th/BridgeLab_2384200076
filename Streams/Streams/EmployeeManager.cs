using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    [Serializable] // Required for Serialization
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, string department, double salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Dept: {Department}, Salary: {Salary}";
        }
    }

    class EmployeeManager
    {
        private static string filePath = "employees.dat";

        public static void SaveEmployees(List<Employee> employees)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, employees);
                }
                Console.WriteLine("Employees serialized & saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during serialization: {ex.Message}");
            }
        }

        public static List<Employee> LoadEmployees()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No saved employees found!");
                return new List<Employee>();
            }

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (List<Employee>)formatter.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during deserialization: {ex.Message}");
                return new List<Employee>();
            }
        }
    }

}

