using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_of_Inheritance
{
    //Base Class
    public class Vehicle
    {
        //Attributes of Vehicle class
        public int MaxSpeed;
        public string FuelType;

        //Constructor
        public Vehicle(int maxSpeed, string fuelType)
        { 
        this.MaxSpeed = maxSpeed;
        this.FuelType = fuelType;
        }

        //method to display information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"---Information of {this.GetType().Name}---");
            Console.WriteLine("Maximum Speed : " + MaxSpeed);
            Console.WriteLine("Fuel Type : " + FuelType);
        }
    }

    //Subclass Car
    class Car : Vehicle
    {
        int SeatCapacity;
        //Constructor of Car class
        public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
        {
            this.SeatCapacity = seatCapacity;
        }
        public override void DisplayInfo()
        {
            //Calling base class method 
            base.DisplayInfo();
            Console.WriteLine("Seat Capacity : " + SeatCapacity);
        }
    }

    //Subclass Truck
    class Truck : Vehicle
    {
        int PayloadCapacity;
        //Constructor of truck class
        public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType) 
        {
            this.PayloadCapacity = payloadCapacity;
        }
        //override the method of vehicle class
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Payload Capacity : " + PayloadCapacity);
        }
    }

    //Subclass Motorcycle
    class Motorcycle : Vehicle
    {
        bool HasSidecar;
        //Constructor of Motorcycle class
        public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) : base(maxSpeed, fuelType)
        {
            this.HasSidecar = hasSidecar;
        }
        //override the method of vehicle class
        public override void DisplayInfo()
        { 
            base.DisplayInfo();
            Console.WriteLine("Motorcycle has a side car : " + (HasSidecar ? "Yes" : "No"));
        }
    }



}

