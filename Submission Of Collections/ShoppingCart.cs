using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Collections
{
    internal class ShoppingCart
    {
        // Dictionary to store product names and their corresponding prices
        private Dictionary<string, double> productPrices = new Dictionary<string, double>();

        // LinkedDictionary to maintain insertion order of products
        private LinkedDictionary<string, double> orderedProducts = new LinkedDictionary<string, double>();

        // SortedDictionary to display products sorted by price
        private SortedDictionary<double, string> sortedProducts = new SortedDictionary<double, string>();

        // Method to add a product to the cart
        public void AddProduct(string productName, double price)
        {
            // Add product to Dictionary
            if (!productPrices.ContainsKey(productName))
            {
                productPrices.Add(productName, price);
            }

            // Add product to LinkedDictionary (maintains order of insertion)
            orderedProducts.Add(productName, price);

            // Add product to SortedDictionary (sorted by price)
            sortedProducts.Add(price, productName);
        }

        // Method to display all products in the Dictionary (unsorted)
        public void DisplayProductsDictionary()
        {
            Console.WriteLine("\nProducts in Dictionary (unsorted):");
            foreach (var product in productPrices)
            {
                Console.WriteLine($"{product.Key}: ${product.Value:F2}");
            }
        }

        // Method to display products in the LinkedDictionary (maintains order of insertion)
        public void DisplayOrderedProducts()
        {
            Console.WriteLine("\nProducts in LinkedDictionary (insertion order):");
            foreach (var product in orderedProducts)
            {
                Console.WriteLine($"{product.Key}: ${product.Value:F2}");
            }
        }

        // Method to display products in the SortedDictionary (sorted by price)
        public void DisplaySortedProducts()
        {
            Console.WriteLine("\nProducts in SortedDictionary (sorted by price):");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"{product.Value}: ${product.Key:F2}");
            }
        }

        // Method to calculate the total price of products in the cart
        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (var price in productPrices.Values)
            {
                totalPrice += price;
            }
            return totalPrice;
        }
    }

    // Custom LinkedDictionary class to maintain insertion order
    public class LinkedDictionary<K, V> : Dictionary<K, V>
    {
        private LinkedList<K> order = new LinkedList<K>();

        public new void Add(K key, V value)
        {
            if (!ContainsKey(key))
            {
                order.AddLast(key);
            }
            base[key] = value;
        }

        public new void Clear()
        {
            base.Clear();
            order.Clear();
        }

        public IEnumerable<KeyValuePair<K, V>> GetOrderedItems()
        {
            foreach (var key in order)
            {
                yield return new KeyValuePair<K, V>(key, this[key]);
            }
        }
    }

}

