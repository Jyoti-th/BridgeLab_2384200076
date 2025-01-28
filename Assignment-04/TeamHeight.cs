using System;
class TeamHeight
{
	public static void Main()
	{
		//declare and initialze the array 
		int[] heights = new int [11];
		
		//create the random object
		Random random = new Random();

		// run the loop which takes the height of 11 players
		for(int i=0;i<heights.Length;i++)
		{
			heights[i] = random.Next(150,251);
		}
		
		//sort the heights of the players
		Array.Sort(heights);
		
		// call the object of the sum of the elements of the array 
		int sum = SumOfElements(heights);
		
		// call the object which calculates the meanHeight
		double meanHeight = MeanHeight(sum , heights.Length);
		
		//call the object which calculates the shortestHeight
		int shortestHeight = ShortestHeight(heights);
		
		////call the object which calculates the tallestHeight
		int tallestHeight= TallestHeight(heights);
		
		
		// print the result
		Console.WriteLine("Sum of all the elements in the array "+sum);
		Console.WriteLine("Mean height of the players on the football team "+meanHeight);
		Console.WriteLine("Shortest height of the players on the football team "+shortestHeight);
		Console.WriteLine("Tallest height of the players on the football team "+tallestHeight);
		
	}
	
	// method calculates the sum of height
	public static int SumOfElements(int [] heights)
	{
			int sum =0;
			for(int i=0;i<heights.Length;i++)
			{
				 sum=sum+heights[i];
			}
		return sum;
	}
	
	//method calculates the meanHeight
	public static double MeanHeight( int sum , int length)
	{
			double meanHeight = (double)sum/length;
			return meanHeight;
	}
	
	// method calculates the shortestHeight
	public static int ShortestHeight(int []heights)
	{
		
		int shortestHeight = heights[0];
		return shortestHeight;
	}
	
	//method calculates the tallestHeight
	public static int TallestHeight(int []heights)
	{
		
		int tallestHeight = heights[heights.Length-1]; 
		return tallestHeight;
	}
}