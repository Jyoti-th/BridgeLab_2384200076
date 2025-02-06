using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Object_Modeling
{
    public class Book
    {
        public string Title;
        public string AuthorName;

        public Book(string title, string authorName)
        {
            this.Title = title;
            this.AuthorName = authorName;   
        }
        public void DisplayBook()
        {
            Console.WriteLine($"Title : {Title}, Author : {AuthorName}");
        }
    }

    //Library class
    public class Library
    {
        public string Name;
        public List<Book> Books;


        public Library(string name)
        {
            this.Name = name;
            Books = new List<Book>();

        }

        public void AddBook(Book book)
        {
            Books.Add(book); 
            Console.WriteLine($"Book : '{book.Title}' added to the '{Name}' Library");
        }
        public void DisplayLibrary()
        {
            Console.WriteLine($"\n Library : {Name}");
            foreach (Book book in Books) 
            {
                book.DisplayBook();
            }
        }

    }
}
