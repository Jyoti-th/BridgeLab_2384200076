using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructure___LinkedList
{
    public class StudentNode
    {
        public int roll_no;
        public string name;
        public int age;
        public char grade;
        public StudentNode Next;



        public StudentNode(int roll_no, string name, int age, char grade)
        {
            this.roll_no = roll_no;
            this.name = name;
            this.age = age;
            this.grade = grade;
            Next = null;
        }
    }

        public class SampleStudent
        {
            public StudentNode head;

            //Insertion at beginning
            public void AddFirst(int roll_no, string name, int age, char grade)
            {
                StudentNode newStudent = new StudentNode(roll_no, name, age, grade);
                newStudent.Next = head;
                head = newStudent;
            Console.WriteLine($"Student with name {name} Added to the list.");
            
        }

            //Insertion at End
            public void AddEnd(int roll_no, string name, int age, char grade)
            {
                StudentNode newStudent = new StudentNode(roll_no, name, age, grade);

                if (head == null)
                {
                    head = newStudent;
                    return;
                }
                StudentNode temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newStudent;
            Console.WriteLine($"Student with name {name} Added to the list.");
            

        }
            //Insertion at Between
            public void AddBetween(int roll_no, string name, int age, char grade, int position)
            {
                StudentNode newStudent = new StudentNode(roll_no, name, age, grade);
                {
                    if (head == null)
                    {
                        head = newStudent;
                        return;
                    }
                    
                    //When position is 1
                    if (position == 1) 
                    {
                        newStudent.Next = head;
                        head = newStudent;
                    }

                    StudentNode temp = head;
                    int count = 1;
                    while (temp.Next != null && count < position - 1)
                    {
                        temp = temp.Next;
                        count++;
                    }

                    if (temp == null || position < 1)
                    {
                        Console.WriteLine("Invalid Position.");
                   
                    return;
                    }

                    newStudent.Next = temp.Next;
                    temp.Next = newStudent;
                Console.WriteLine($"Student with name {name} Added to the list.");
                Console.WriteLine("--------------------------------------------");
            }
            }
            //Delete a student record by Roll Number.
            public void DeleteNode(int rollno)
            {
               
                //Check if list is empty
                if (head == null)
                {
                    Console.WriteLine("List is empty");
                
                return;
                }
                //Check if deleted node is the head node
                if (head.roll_no == rollno)
                {
                    head = head.Next;
                    Console.WriteLine($"Student with Roll No. {rollno} deleted. ");
                
                return;
                }
                //Traverse the list to match the roll.no
                StudentNode temp = head;
                while (temp.Next != null && temp.Next.roll_no != rollno)
                {
                    temp = temp.Next;
                }

            if (temp.Next == null)
            {

                Console.WriteLine("Student not found.");
                
                return;
            }
                temp.Next = temp.Next.Next;
        
                Console.WriteLine($"Student with Roll No. {rollno} deleted. ");
            Console.WriteLine("--------------------------------------------");
        }
        // Method to Search for a student record by Roll Number.
        public void SearchStudent(int rollno)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            StudentNode temp = head;
            while (temp != null)
            {
                if (temp.roll_no == rollno)
                {
                    Console.WriteLine($"Student found : Roll.No - {temp.roll_no}, Name - {temp.name}, Age - {temp.age}, Grade - {temp.grade}.");
                    Console.WriteLine("--------------------------------------------"); 
                    return;

                }
                temp = temp.Next;

            }
            Console.WriteLine("Student Not found.");
            Console.WriteLine("--------------------------------------------");

        }

        //Method to Display all student records.
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            StudentNode temp = head;
            Console.WriteLine("----Student Records----");

            while (temp != null)
            {
                Console.WriteLine($" Roll.No - {temp.roll_no}, Name - {temp.name}, Age - {temp.age}, Grade - {temp.grade}.");
                temp = temp.Next;
            }
            Console.WriteLine("--------------------------------------------");
        }
        //Update a student's grade based on their Roll Number.
        public void UpdateStudent(int rollno, char newGrade)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty.");
                return;
            }

            StudentNode temp = head;
            while (temp != null)
            {
                if (temp.roll_no == rollno)
                {
                    temp.grade = newGrade;
                    Console.WriteLine($"The grade of student {temp.name} updated successfully.");
                    Console.WriteLine("--------------------------------------------");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found.");

            Console.WriteLine("--------------------------------------------");
        }


    }
}

