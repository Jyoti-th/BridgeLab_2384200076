using System;
class DistributingPens
{
	int totalPens = 14;
	int totalStudents = 3;
	 
	//Method to calculate distributed pen and non - distributed pens
	public void CalculateDistribution()
	{
		// number of pens each student will get
		int penPerStudent = totalPens/totalStudents; 
		// number of non-distributed pens
		int nonDistributedPens = totalPens%totalStudents;
		
		Console.WriteLine("The Pen Per Student is " + penPerStudent + " and the remaining pen not distributed is " + nonDistributedPens);
	}
	public static void  Main()
	{
		//Instance of class
		DistributingPens obj = new DistributingPens();
		//Calling the method CalculateDistribution
		obj.CalculateDistribution();
	}
}