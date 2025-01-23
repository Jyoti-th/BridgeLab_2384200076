using System;
class Travel
    {
		public static void Main()
		{
			Travel obj = new Travel();
			obj.GetJourneyDetails();
		}
		public void GetJourneyDetails()
        {
            // taking user input for name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            
            // taking  input to enter starting city
            Console.Write("Enter the starting city: ");
            string fromCity = Console.ReadLine();

            //taking input to enter via city
            Console.Write("Enter the via city: ");
            string viaCity = Console.ReadLine();

            // taking input to enter destination
            Console.Write("Enter the destination city: ");
            string toCity = Console.ReadLine();

            
            // Get user input for distances 
            Console.Write("Enter the distance from starting city to via city  in miles ");
            double fromToVia = Convert.ToDouble(Console.ReadLine());
            
			
            Console.Write("Enter the distance from via city to destination city in miles: ");
            double viaToFinalCity = Convert.ToDouble(Console.ReadLine());
            
			//Get the user input for timeTaken
			Console.Write("Enter the time taken  from city to via city :");
			int timeFromToVia = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Enter the time taken  via city to final city :");
			int timeViaToFinal = Convert.ToInt32(Console.ReadLine());
			
            
            // Calculate total distance and average speed
            double totalDistance = fromToVia + viaToFinalCity;
            double totalTime = timeFromToVia+timeViaToFinal;
            
            // Display results
            Console.WriteLine("The results of the trip are: Traveler's Name: "+name+"2. Total Distance: "+totalDistance+"3. Total Time: "+totalTime);
        }
    }