using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_of_Inheritance
{
    public class Animal
    {
        string Name;
        int Age;

        //Constructor of Animal class
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        //Method of Animal class that is virtual
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    //Subclass dog
    class Dog : Animal
    {
        //calling the animal class constructor
        public Dog(string name, int age) : base(name, age) { }
        public override void MakeSound()//overridden method
        {
            Console.WriteLine("Dog barks.");

        }
    }
    //Subclass cat
    class Cat : Animal
    {
        //calling the animal class constructor
        public Cat(string name, int age) : base(name, age) { }
        public override void MakeSound()//overridden method
        {
            Console.WriteLine("Cat meows.");
        }
    }
    //Subclass bird inherited by animal class
    class Bird : Animal
    {
        //calling the animal class constructor
        public Bird(string name, int age) : base(name, age) { }
        public override void MakeSound()//overridden method 
        {
            Console.WriteLine("Bird Chirps.");
        }
    }
}
