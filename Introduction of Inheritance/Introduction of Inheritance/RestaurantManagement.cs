using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_of_Inheritance
{
    using System;

    namespace RestaurantManagement
    {
        // Base Class (RestaurantPerson)  
        public class RestaurantPerson
        {
            protected string Name;
            protected int Id;

            // Constructor
            public RestaurantPerson(string name, int id)
            {
                this.Name = name;
                this.Id = id;
            }

            // Method to display person information
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"ID: {Id}");
            }
        }

        // Interface (IWorker) for achiving Multiple Inheritance
        public interface IWorker
        {
            void PerformDuties();
        }

        // Subclass (Chef) 
        public class Chef : RestaurantPerson, IWorker
        {
            public Chef(string name, int id) : base(name, id) { }

            // Implementing PerformDuties method
            public void PerformDuties()
            {
                Console.WriteLine($"{Name} is preparing dishes in the kitchen.");
            }
        }

        // Subclass (Waiter) 
        public class Waiter : RestaurantPerson, IWorker
        {
            public Waiter(string name, int id) : base(name, id) { }

            // Implementing PerformDuties method
            public void PerformDuties()
            {
                Console.WriteLine($"{Name} is serving customers at the restaurant.");
            }
        }

        
       
    }

}
