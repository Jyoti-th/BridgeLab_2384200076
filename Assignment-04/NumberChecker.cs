using System;
class NumberChecker
{
	public static void Main()
	{
		Console.WriteLine("Enter the number");
		int n = Convert.ToInt32(Console.ReadLine());
		
		
		
		int count = CountDigits(n);
		Console.WriteLine("The count of the number is "+count);
		
		
		
		int[] digitsArray = StoreDigitsInArray(n);
		Console.WriteLine("Digits of the number "+7n);
        foreach (int digit in digitsArray)
        {
            Console.Write(digit + " ");
        }
		Console.WriteLine();
		
		bool isDuck = DuckNumber(n);
        Console.WriteLine(n + (isDuck ? " is a Duck Number." : " is NOT a Duck Number."));
		
		// Check if the number is an Armstrong number
       bool isArmstrong = IsArmstrongNumber(digitsArray, n);
        Console.WriteLine("Is Armstrong Number: " + isArmstrong);
		
		
		// Find and display the largest and second largest digits in the number
       (int largest, int secondLargest) = FindLargestAndSecondLargest(digitsArray);
        Console.WriteLine("Largest Digit: " + largest);
        Console.WriteLine("Second Largest Digit: " + secondLargest);

        // Find and display the smallest and second smallest digits in the number
       // Find and display the smallest and second-smallest digits
        (int smallest, int secondSmallest) = FindSmallestAndSecondSmallest(digitsArray);
        Console.WriteLine("Smallest Digit: " + smallest);
        Console.WriteLine("Second Smallest Digit: " + secondSmallest);
    }
	
	
	//Find the count of digits in the number
	public static int CountDigits(int num)
	{
		int count =0;
		int number = Math.Abs(num);
		
		if(number == 0)
		return 0;
		
		while(number>0)
		{
			number=number/10;
			count++;
		}
			return count;
	
		
	}
	public static int[] StoreDigitsInArray(int num)
	{
		int count = CountDigits(num);
		
		int[] digitsArray = new int[count];
		
		for(int i = count-1;i>=0;i--) 
		{
			digitsArray[i] = num%10;
			num = num/10;
		}
		return digitsArray;
		
	}	
	
	public static bool DuckNumber(int num)
	{
		int [] digits = StoreDigitsInArray(Math.Abs(num));
		for(int i=0;i<digits.Length;i++)
		{
			if(digits[i]==0)
			{
				return true;
			}
		}
		return false;
	}
	
	// Method to check if the number is an Armstrong number
    public static bool IsArmstrongNumber(int[] digits, int originalNumber)
    {
        int power = digits.Length;  // The number of digits determines the power
        int sum = 0;

        // Sum the digits raised to the power of the number of digits
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, power);  // Raise each digit to the power of 'power' and add it to the sum
        }

        // If the sum equals the original number, it's an Armstrong number
        return sum == originalNumber;
    }

    // Method to find the largest and second largest digits
    public static (int, int) FindLargestAndSecondLargest(int[] digits)
    {
        int largest = Int32.MinValue;  // Start with the smallest possible value
        int secondLargest = Int32.MinValue;  // Start with the smallest possible value

        // Loop through the digits array to find the largest and second largest
        foreach (int digit in digits)
        {
            if (digit > largest)  // If the current digit is larger than the largest, update both values
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit < largest)  // If the current digit is smaller than largest but larger than second largest
            {
                secondLargest = digit;
            }
        }

        // Return the largest and second largest digits
        return (largest, secondLargest);
    }

    // Method to find the smallest and second smallest digits
    public static (int, int) FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = Int32.MaxValue;  // Start with the largest possible value
        int secondSmallest = Int32.MaxValue;  // Start with the largest possible value

        // Loop through the digits array to find the smallest and second smallest
        foreach (int digit in digits)
        {
            if (digit < smallest)  // If the current digit is smaller than the smallest, update both values
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit > smallest)  // If the current digit is larger than smallest but smaller than second smallest
            {
                secondSmallest = digit;
            }
        }

        // Return the smallest and second smallest digits
        return (smallest, secondSmallest);
    }

}