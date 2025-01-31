using System;

class TemperatureConverter
{
    // Function to convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Function to convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Function to get user input for temperature and the conversion type
    static void GetInput(out double tempValue, out string conversionType)
    {
        Console.WriteLine("Enter the temperature value:");

        while (!double.TryParse(Console.ReadLine(), out tempValue))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("Do you want to convert from Fahrenheit to Celsius (F) or Celsius to Fahrenheit (C)?");
        conversionType = Console.ReadLine().ToUpper();

        while (conversionType != "F" && conversionType != "C")
        {
            Console.WriteLine("Invalid choice. Please enter 'F' for Fahrenheit to Celsius or 'C' for Celsius to Fahrenheit.");
            conversionType = Console.ReadLine().ToUpper();
        }
    }

    // Function to display the result of the conversion
    static void DisplayResult(double originalTemp, double convertedTemp, string conversionType)
    {
        if (conversionType == "F")
        {
            Console.WriteLine(originalTemp + "°F is equal to " + convertedTemp + "°C.");
        }
        else if (conversionType == "C")
        {
            Console.WriteLine(originalTemp + "°C is equal to " + convertedTemp + "°F.");
        }
    }

    // Main function that drives the program
    static void Main(string[] args)
    {
        // Get the input temperature and conversion type from the user
        double tempValue;
        string conversionType;
        GetInput(out tempValue, out conversionType);

        // Perform the conversion based on the user's choice
        double convertedTemp = (conversionType == "F") ? FahrenheitToCelsius(tempValue) : CelsiusToFahrenheit(tempValue);

        // Display the result
        DisplayResult(tempValue, convertedTemp, conversionType);
    }
}
