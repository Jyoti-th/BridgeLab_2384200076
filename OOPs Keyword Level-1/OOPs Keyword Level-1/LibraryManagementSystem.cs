using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Keyword_Level_1
{
    internal class LibraryManagementSystem
    {
        private static string LibraryName = "GLA Library";

        private readonly string isbn;
        private string title;
        private string author;


        public LibraryManagementSystem(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }

        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library Nmae :" + LibraryName);
        }

        public void DisplayBookDetails()
        {
            if (this is LibraryManagementSystem)
            {
                Console.WriteLine("Book Details:");
                Console.WriteLine("Title: " + this.title);
                Console.WriteLine("Author: " + this.author);
                Console.WriteLine("ISBN: " + this.isbn);
            }
            else
            {
                Console.WriteLine("Invalid book object.");
            }
        }
    }
}
