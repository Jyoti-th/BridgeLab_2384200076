using System;

class CarRental
{
    // Properties
    public string CustomerName { get; set; }
    public string CarModel { get; set; }
    public int RentalDays { get; set; }
    public double DailyRate { get; set; } // Removed direct initialization

    // Default Constructor
    public CarRental()
    {
        CustomerName = "John Doe";
        CarModel = "Standard";
        RentalDays = 1;
        DailyRate = 100.0; // Moved initialization here
    }

    // Parameterized Constructor
    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.CustomerName = customerName;
        this.CarModel = carModel;
        this.RentalDays = rentalDays > 0 ? rentalDays : 1;
        this.DailyRate = 100.0; // Ensure DailyRate is initialized
    }

    // Method to Calculate Total Cost
    public double CalculateTotalCost()
    {
        return RentalDays * DailyRate;
    }

    // Method to Display Rental Details
    public void Display()
    {
        Console.WriteLine("Customer: " + CustomerName + ", Car Model: " + CarModel + 
                          ", Rental Days: " + RentalDays + ", Total Cost: $" + CalculateTotalCost().ToString("F2"));
    }
}

class Program
{
    static void Main()
    {
        // Using Default Constructor
        CarRental rental1 = new CarRental();
        rental1.Display();
        
        // Using Parameterized Constructor with "Joe Dalton"
        CarRental rental2 = new CarRental("Joe Dalton", "Rolls Royce", 5);
        rental2.Display();
    }
}
