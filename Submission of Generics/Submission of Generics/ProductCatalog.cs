using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Submission_of_Generics
{
        public abstract class ProductCategory
        {
            public abstract string CategoryName { get; }

        }

        public class BookCategory : ProductCategory
        {
            public override string CategoryName => "Books";
        }

        public class ClothingCategory : ProductCategory
        {
            public override string CategoryName => "Clothing";
        }

        public class Product<T> where T : ProductCategory
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public T Category { get; set; }

            public Product(string name, double price, T category)
            {
                Name = name;
                Price = price;
                Category = category;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Product: {Name}, Category: {Category.CategoryName}, Price: {Price}");
            }
        }

        public class DiscountManager
        {
            public static void ApplyDiscount<T>(Product<T> product, double percentage) where T : ProductCategory
            {
                product.Price -= product.Price * (percentage / 100);
                Console.WriteLine($"Discount applied! New price of {product.Name}: {product.Price}");
            }
        }
    }
