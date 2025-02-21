﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class InvalidInput
    {
   
        // Method to calculate interest
        static double CalculateInterest(double amount, double rate, int years)
        {
            if (amount < 0 || rate < 0)
            {
                throw new ArgumentException("Amount and rate must be positive");
            }

            // Simple Interest Formula: Interest = (Amount * Rate * Years) / 100
            return (amount * rate * years) / 100;
        }

        public static void Invalid()
        {
            try
            {
                // Taking user input
                Console.Write("Enter principal amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter interest rate (%): ");
                double rate = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number of years: ");
                int years = Convert.ToInt32(Console.ReadLine());

                // Calling CalculateInterest method
                double interest = CalculateInterest(amount, rate, years);
                Console.WriteLine($"Calculated Interest: {interest}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Invalid input: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numeric values.");
            }
        }
    }

}

