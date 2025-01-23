using System;

class TemperatureConversion2
{
    // Method to convert Fahrenheit to celsius
    public void ConvertToCelsius()
    {
		//Taking Temperature input in celsius
		Console.Write("Enter temperature in Farenheit: ");
        double farenheit = Convert.ToDouble(Console.ReadLine());
		//Convert Fahrenheit to celsius
        double celsiusResult = ((farenheit-32)*5/9);
		
		//Print the result
		Console.WriteLine(" The " +  farenheit +" Fahrenheit is  "+ celsiusResult+" celsius");
    }

    public static void Main()
    {
		//Instance of a class
		TemperatureConversion2 obj = new TemperatureConversion2();
		//Calling the method
		obj.ConvertToCelsius();
    }
}
