using System;
public class Handshakes
{
	//Non-static method to calculate number of possible handshake among n number of students
	public int NumberOfHandshakes(int NumberOfStudents)
	{
		//create a variable to store the result (used Formula to calculate maximum Handshakes)
		int possibleHandshakes = (NumberOfStudents*(NumberOfStudents - 1))/2;
		return possibleHandshakes;
	}
	
	public static void Main(String[] args)
	{
		//User Input 
		Console.Write("Enter the total number of students : ");
		int NumberOfStudents = Convert.ToInt32(Console.ReadLine());
		//Instance of a class to call non-static method in to static block
		Handshakes obj = new Handshakes();
		//Display Result
		Console.WriteLine("Maximum number of Handshake among N student is : " + obj.NumberOfHandshakes(NumberOfStudents));
	}
}