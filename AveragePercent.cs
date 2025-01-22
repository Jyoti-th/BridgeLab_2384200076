using System;
public class AveragePercent
{
	int mathsMark = 94;
	int physicsMark = 95;
	int chemistryMark = 96;
	int totalMarks = 300;
	
	// Method to calculate Average of Marks in PCM
	public double CalculateAverage()
	{
		//obtained marks of Sam in PCM
		int obtainedMarks = mathsMark + physicsMark +chemistryMark;
		//Return average percent of marks
		return (obtainedMarks/(double)totalMarks) * 100;
		
	}
	
	public static void Main()
	{
		//Instance of class
		AveragePercent obj = new AveragePercent();
		
		//Display the Average marks in PCM by calling method CalculateAverage
		Console.WriteLine("Sam’s average mark in PCM is " + obj.CalculateAverage()+"%");
	}
}
