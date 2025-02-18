using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Generics
{
        public abstract class WarehouseItem
        {
            public string name { get; set; }
            public double price { get; set; }

            public WarehouseItem(string name, double price)
            {
                this.name = name;
                this.price = price;
            }

            public abstract void DisplayInfo();
        }

        public class Electronics : WarehouseItem
        {
            public Electronics(string name, double price) : base(name, price) { }


            public override void DisplayInfo()
            {
                Console.WriteLine($"[Electronics] Name : {name} , price : ${price}");
            }
        }

        public class Groceries : WarehouseItem
        {
            public Groceries(string name, double price) : base(name, price) { }

            public override void DisplayInfo()
            {
                Console.WriteLine($"[Groceries] Name : {name} , price : ${price}");
            }

        }

        public class Furniture : WarehouseItem
        {
            public Furniture(string name, double price) : base(name, price) { }

            public override void DisplayInfo()
            {
                Console.WriteLine($"[Furniture] Name : {name} , price : ${price}");
            }
        }

        public class Storage<T> where T : WarehouseItem
        {
            private List<T> inventory = new List<T>();

            public void Add(T item)
            {
                inventory.Add(item);
                Console.WriteLine($"{item.name} added to the storage.");
            }

            public void DisplayAllItems()
            {
                Console.WriteLine($"---Warehouse Inventory---");
                foreach (var item in inventory)
                {
                    item.DisplayInfo();
                }
            }
        }
    }


