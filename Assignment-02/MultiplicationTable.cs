using System;
class MultiplicationTable
{
public static void Main()
{
	//call the method
	Table();
}
public static void Table()
{
	//take the input
	Console.Write("Enter any number: ");
	
	//convert it into int
	int n = Convert.ToInt32(Console.ReadLine());
	
	//declare and initialize and array
	int []multiplicationResult = new int[10];
	
	//store the result into an array
	for(int i=0;i<multiplicationResult.Length;i++)
	{
		multiplicationResult[i] = (i+1)*n;
	}		
	//print the result from  6 to 9
 	for(int i=6;i<=9;i++)
	{
		Console.WriteLine(n+" * "+(i)+" = "+multiplicationResult[i]);
	}
}
}
