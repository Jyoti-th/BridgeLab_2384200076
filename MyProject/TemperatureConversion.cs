using System;

class TemperatureConversion
{
    // Method to convert Celsius to Fahrenheit
    public void ConvertToFahrenheit()
    {
		//Taking Temperature input in celsius
		Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
		//Convert celsius to farenheit
        double fahrenheitResult = (celsius * 9 / 5) + 32;
		
		//Print the result
		Console.WriteLine(" The " +  celsius+" Celsius is "+ fahrenheitResult+" Fahrenheit");
    }

    public static void Main()
    {
		//Instance of a class
		TemperatureConversion obj = new TemperatureConversion();
		//Calling the method
		obj.ConvertToFahrenheit();
    }
}
