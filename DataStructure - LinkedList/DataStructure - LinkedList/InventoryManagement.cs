using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure___LinkedList
{
    public class InventoryNode
    {
        public string itemName;
        public int itemId;
        public int quantity;
        public double price;
        public InventoryNode Next;

        //Constructor to initialize attributes of inventory node
        public InventoryNode(string itemName, int itemId, int quantity, double price)
        {
            this.itemName = itemName;
            this.itemId = itemId;
            this.quantity = quantity;
            this.price = price;
            Next = null;
        }
    }
    internal class InventoryManagement
    {
        public InventoryNode head;
        //Method to Add an item at the beginning
        public void AddAtFirst(string itemName, int itemId, int quantity, double price)
        {

            InventoryNode newInventory = new InventoryNode(itemName, itemId, quantity, price);
            if (head == null)
            {
                head = newInventory;
                Console.WriteLine($"Item {itemName} Added to the Inventory.");
                return;
            }
            else
            {
                newInventory.Next = head;
                head = newInventory;
                Console.WriteLine($"Item {itemName} Added to the Inventory.");
            }
        }
        //Method to Add an item at the end 
        public void AddAtEnd(string itemName, int itemId, int quantity, double price)
        {
            InventoryNode newInventory = new InventoryNode(itemName, itemId, quantity, price);
            if (head == null)
            {
                head = newInventory;
                Console.WriteLine($"Item {itemName} Added to the Inventory.");
                return;
            }

            InventoryNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;

            }
            temp.Next = newInventory;
            Console.WriteLine($"Item {itemName} Added to the Inventory.");
        }
        //Method to Add an item at Specific Position
        public void AddAtSpecific(string itemName, int itemId, int quantity, double price, int position)
        {
            InventoryNode newInventory = new InventoryNode(itemName, itemId, quantity, price);
            //Check List is empty
            if (head == null)
            {
                head = newInventory;
                Console.WriteLine($"Item {itemName} Added to the Inventory.");
                return;

            }
            //If given position is 1
            if (position == 1)
            {
                newInventory.Next = head.Next;
                head = newInventory;
            }
            //Temproary variavle to traverse the list
            InventoryNode temp = head;
            int count = 1;

            while (temp.Next != null && count < position - 1)
            {
                temp = temp.Next;
            }
            if (temp == null || position < 1)
            {
                Console.WriteLine("Invalid Position");
                return;
            }

            newInventory.Next = temp.Next;
            temp.Next = newInventory;
            Console.WriteLine($"Item {itemName} Added to the Inventory.");
            Console.WriteLine("--------------------------------------------------------------------------------");

        }

        //Method to Remove an item based on Item ID.
        public void RemoveItem(int id)
        {
            //Check if list is empty
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            if (head.itemId == id)
            {
                head = head.Next;
                Console.WriteLine($"Item with id {id} is deleted.");
                return;
            }
            InventoryNode temp = head;
            while (temp.Next != null && temp.Next.itemId != id)
            {
                temp = temp.Next;
            }
            if (temp.Next == null)
            {
                Console.WriteLine("Item not found.");
                return;
            }
            //Deleting the item nd linking again
            temp.Next = temp.Next.Next;
            Console.WriteLine($"Item with id {id} is deleted.");
            Console.WriteLine("--------------------------------------------------------------------------------");

        }
        //Method to Display All the items
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty.");
                return;
            }
            InventoryNode temp = head;
            Console.WriteLine("Items in Inventory");
            while (temp != null)
            {
                Console.WriteLine($"Item Name : {temp.itemName}, Item Id : {temp.itemId}, Item Quantity : {temp.quantity}, Item Price : {temp.price}");
                temp = temp.Next;
            }
            Console.WriteLine("--------------------------------------------------------------------------------");

        }
        //Method to Search for an item based on Item ID or Item Name.
        public void SearchItem(int id, string name)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty.");
                return;
            }
            InventoryNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (id != null && temp.itemId == id)
                {
                    Console.WriteLine($"Item Found - Item Name : {temp.itemName}, Item Id : {temp.itemId}, Item Quantity : {temp.quantity}, Item Price : {temp.price}");
                    found = true;
                }
                //Check by item name 
                if (!string.IsNullOrEmpty(name) && temp.itemName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Item Found! ID: {temp.itemId}, Name: {temp.itemName}, Quantity: {temp.quantity}, Price: {temp.price}");
                    found = true;
                }

                temp = temp.Next;
            }
            Console.WriteLine("--------------------------------------------------------------------------------");

        }

        public void SortInventory(string criteria, bool ascending)
        {
            if (head == null || head.Next == null)
            {
                Console.WriteLine("List is too small to sort.");
                return;
            }

            bool swapped;
            do
            {
                swapped = false;
                InventoryNode current = head;
                InventoryNode prev = null;

                while (current.Next != null)
                {
                    bool shouldSwap = false;

                    //  Sort by Name
                    if (criteria == "name")
                    {
                        if (ascending)
                            shouldSwap = string.Compare(current.itemName, current.Next.itemName, StringComparison.OrdinalIgnoreCase) > 0;
                        else
                            shouldSwap = string.Compare(current.itemName, current.Next.itemName, StringComparison.OrdinalIgnoreCase) < 0;
                    }
                    //  Sort by Price
                    else if (criteria == "price")
                    {
                        if (ascending)
                            shouldSwap = current.price > current.Next.price;
                        else
                            shouldSwap = current.price < current.Next.price;
                    }

                    //  Swap Nodes
                    if (shouldSwap)
                    {
                        string tempName = current.itemName;
                        int tempId = current.itemId;
                        int tempQty = current.quantity;
                        double tempPrice = current.price;

                        current.itemName = current.Next.itemName;
                        current.itemId = current.Next.itemId;
                        current.quantity = current.Next.quantity;
                        current.price = current.Next.price;

                        current.Next.itemName = tempName;
                        current.Next.itemId = tempId;
                        current.Next.quantity = tempQty;
                        current.Next.price = tempPrice;

                        swapped = true;
                    }

                    prev = current;
                    current = current.Next;
                }
            } while (swapped);

            Console.WriteLine($"Inventory sorted by {criteria} in {(ascending ? "ascending" : "descending")} order.");
            Console.WriteLine("--------------------------------------------------------------------------------");

        }

    }
}
  