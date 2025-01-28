using System;

public class UnitConverter3
{
    // Convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Convert Pounds to Kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    // Convert Kilograms to Pounds
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    // Convert Gallons to Liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    // Convert Liters to Gallons
    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
}

public class Program
{
    public static void Main()
    {
        // Fahrenheit to Celsius
        Console.Write("Enter Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = UnitConverter3.ConvertFahrenheitToCelsius(fahrenheit);
        Console.WriteLine(fahrenheit+" Fahrenheit = "+celsius+" Celsius");

        // Celsius to Fahrenheit
        Console.Write("Enter Celsius: ");
        celsius = double.Parse(Console.ReadLine());
        fahrenheit = UnitConverter3.ConvertCelsiusToFahrenheit(celsius);
        Console.WriteLine(celsius+" Celsius = "+fahrenheit+" Fahrenheit");

        // Pounds to Kilograms
        Console.Write("Enter Pounds: ");
        double pounds = double.Parse(Console.ReadLine());
        double kilograms = UnitConverter3.ConvertPoundsToKilograms(pounds);
        Console.WriteLine(pounds+" Pounds = "+kilograms+" Kilograms");

        // Kilograms to Pounds
        Console.Write("Enter Kilograms: ");
        kilograms = double.Parse(Console.ReadLine());
        pounds = UnitConverter3.ConvertKilogramsToPounds(kilograms);
        Console.WriteLine(kilograms +" Kilograms = "+pounds+" Pounds");

        // Gallons to Liters
        Console.Write("Enter Gallons: ");
        double gallons = double.Parse(Console.ReadLine());
        double liters = UnitConverter3.ConvertGallonsToLiters(gallons);
        Console.WriteLine(gallons + " Gallons = " +liters + " Liters");

        // Liters to Gallons
        Console.Write("Enter Liters: ");
        liters = double.Parse(Console.ReadLine());
        gallons = UnitConverter3.ConvertLitersToGallons(liters);
        Console.WriteLine(liters+" Liters = " + gallons +" Gallons");
    }
}
