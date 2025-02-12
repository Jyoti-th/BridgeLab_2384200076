using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure___LinkedList
{
    internal class CallingAllClass
    {
        //Student Record MAnagement System
        public void CallingStudentRecordManagement()
        {
            SampleStudent obj = new SampleStudent();
            obj.AddFirst(1, "Saloni", 23, 'B');
            obj.AddEnd(2, "Jyoti", 23, 'A');
            obj.AddEnd(3, "Sandhya", 24, 'B');
            obj.AddEnd(4, "Ram", 18, 'C');

            obj.DeleteNode(2);
            obj.SearchStudent(3);
            obj.SearchStudent(2);
            obj.DisplayAll();
            obj.UpdateStudent(2, 'B');
            obj.UpdateStudent(1, 'A');
            obj.DisplayAll();
        }
        //Inventory Management System
        public void CallingInventoryManagement()
        {
            InventoryManagement inventoryManagement = new InventoryManagement();
            inventoryManagement.AddAtFirst("Sugar", 101, 2, 65.5);
            inventoryManagement.AddAtEnd("Soap", 102, 12, 120);
            inventoryManagement.AddAtEnd("Rice", 103, 3, 300);
            inventoryManagement.AddAtSpecific("Flour", 104, 10, 500, 2);

            inventoryManagement.Display();
            inventoryManagement.RemoveItem(103);
            inventoryManagement.Display();
            inventoryManagement.SortInventory("Soap", true);
            inventoryManagement.Display();

        }
        //Movie Management System
        public void CallingMovieManagement()
        {
            MovieList movieList = new MovieList();
            movieList.AddMovieAtEnd("Inception", "Christopher Nolan", 2010, 8.8);
            movieList.AddMovieAtBeginning("Interstellar", "Christopher Nolan", 2014, 8.6);
            movieList.AddMovieAtPosition("The Matrix", "Lana Wachowski", 1999, 8.7, 1);

            Console.WriteLine("Movies in Forward Order:");
            movieList.DisplayMoviesForward();

            Console.WriteLine("\nMovies in Reverse Order:");
            movieList.DisplayMoviesReverse();

            Console.WriteLine("\nUpdating rating of Inception to 9.0");
            movieList.UpdateRating("Inception", 9.0);

            Console.WriteLine("\nSearching for movies directed by Christopher Nolan:");
            movieList.SearchByDirectorOrRating("Christopher Nolan", 0);

            Console.WriteLine("\nRemoving 'The Matrix' from the list");
            movieList.RemoveMovie("The Matrix");

            Console.WriteLine("\nFinal Movie List:");
            movieList.DisplayMoviesForward();
        }
        //Task Schedular
        public void CallingTaskSchedular()
        {
            TaskScheduler scheduler = new TaskScheduler();
            scheduler.AddAtEnd(1, "Task A", 2, DateTime.Now.AddDays(1));
            scheduler.AddAtBeginning(2, "Task B", 1, DateTime.Now.AddDays(2));
            scheduler.AddAtEnd(3, "Task C", 3, DateTime.Now.AddDays(3));

            Console.WriteLine("All Tasks:");
            scheduler.DisplayTasks();

            Console.WriteLine("\nViewing Current Task:");
            scheduler.ViewCurrentTask();

            Console.WriteLine("\nSearching for tasks with Priority 2:");
            scheduler.SearchByPriority(2);

            Console.WriteLine("\nRemoving Task with ID 2");
            scheduler.RemoveTask(2);
            scheduler.DisplayTasks();
                        //break;
        }
        //Library Management System
        public void CallingLibraryManagement()
        {
            LibraryManagementSystem library = new LibraryManagementSystem();
            library.AddAtEnd(1, "Book A", "Author X", "Fiction", true);
            library.AddAtBeginning(2, "Book B", "Author Y", "Sci-Fi", false);
            library.AddAtEnd(3, "Book C", "Author Z", "History", true);

            Console.WriteLine("All Books (Forward Order):");
            library.DisplayBooksForward();

            Console.WriteLine("\nUpdating Availability of Book ID 2 to Available");
            library.UpdateAvailability(2, true);
            library.DisplayBooksForward();

            Console.WriteLine("\nSearching for Book 'Book C':");
            library.SearchBook("Book C");

            Console.WriteLine("\nTotal Number of Books: " + library.CountBooks());

            Console.WriteLine("\nRemoving Book ID 1");
            library.RemoveBook(1);
            library.DisplayBooksForward();
        }
        //Round-Robin Scheduling Algorithm
        public void CallingRoundRobin()
        {

            RoundRobinSchedulingAlgorithm scheduler2 = new RoundRobinSchedulingAlgorithm();
            scheduler2.AddProcess(1, 10, 1);
            scheduler2.AddProcess(2, 5, 2);
            scheduler2.AddProcess(3, 8, 1);
            scheduler2.AddProcess(4, 12, 3);

            Console.WriteLine("Initial Process Queue:");
            scheduler2.DisplayProcesses();

            Console.WriteLine("\nStarting Round Robin Scheduling with Time Quantum = 4");
            scheduler2.RoundRobinScheduling(4);
        }
        //Social Media Friend Connections
        public void CallingSocialMedia()
        {
            SocialMediaFriendConnections socialNetwork = new SocialMediaFriendConnections();
            socialNetwork.AddUser(1, "saloni", 25);
            socialNetwork.AddUser(2, "nidhi", 27);
            socialNetwork.AddUser(3, "tanya", 23);
            socialNetwork.AddUser(4, "vishi", 30);

            socialNetwork.AddFriend(1, 2);
            socialNetwork.AddFriend(1, 3);
            socialNetwork.AddFriend(2, 3);
            socialNetwork.AddFriend(3, 4);

            Console.WriteLine("Friend Lists:");
            socialNetwork.DisplayFriends(1);
            socialNetwork.DisplayFriends(2);
            socialNetwork.DisplayFriends(3);
            socialNetwork.DisplayFriends(4);

            Console.WriteLine("\nFinding Mutual Friends:");
            socialNetwork.FindMutualFriends(1, 3);
            socialNetwork.FindMutualFriends(2, 4);

            Console.WriteLine("\nFriend Counts:");
            socialNetwork.CountFriends();
        }
        // Undo/Redo Functionality for Text Editor
        public void CallingTextEditor()
        {
            Undo_RedoFunctionalityforTextEditor textEditor = new Undo_RedoFunctionalityforTextEditor();
            textEditor.AddState("Hello");
            textEditor.AddState("Hello, World");
            textEditor.AddState("Hello, World!");

            textEditor.DisplayCurrentState();
            textEditor.Undo();
            textEditor.Undo();
            textEditor.Redo();
        }
        //Online Ticket Reservation System
        public void CallingTicketReservation()
        {
            OnlineTicketReservationSystem ticketSystem = new OnlineTicketReservationSystem();
            ticketSystem.AddTicket(1, "Alice", "Inception", "A1");
            ticketSystem.AddTicket(2, "Bob", "Interstellar", "B2");
            ticketSystem.AddTicket(3, "Charlie", "Dunkirk", "C3");

            Console.WriteLine("\nAll Booked Tickets:");
            ticketSystem.DisplayTickets();

            Console.WriteLine("\nSearch for tickets by movie name 'Interstellar':");
            ticketSystem.SearchTicket("Interstellar");

            Console.WriteLine("\nTotal Tickets: " + ticketSystem.TotalTickets());

            Console.WriteLine("\nRemoving Ticket ID 2:");
            ticketSystem.RemoveTicket(2);

            Console.WriteLine("\nUpdated Ticket List:");
            ticketSystem.DisplayTickets();
        }




    }
}
