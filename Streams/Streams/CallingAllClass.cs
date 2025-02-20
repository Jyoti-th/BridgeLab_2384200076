using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class CallingAllClass
    {
        //File Handling - Read and Write a Text File 
        public void CallingReadWrite()
        {
            string sourceFile = @"C:\Users\JYOTI THAKUR\Desktop\source.txt";
            string destinationFile = @"C:\Users\JYOTI THAKUR\Desktop\destination.txt";


            try
            {
                // Check if source file exists
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Error: Source file does not exist!");
                    return;
                }

                // Call CopyFile method
                ReadWrite.CopyFile(sourceFile, destinationFile);

                Console.WriteLine(" File copied successfully from source.txt to destination.txt");
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOException Occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }

        //Buffered Streams - Efficient File Copy 
        public void CallingBufferedFile()
        {
            string sourceFile = @"C:\Users\JYOTI THAKUR\Desktop\largefile.txt.txt";
            string destBuffered = @"C:\Users\JYOTI THAKUR\Desktop\buffered_copy.txt";
            string destUnbuffered = @"C:\Users\JYOTI THAKUR\Desktop\unbuffered_copy.txt";

            // Measure time for Unbuffered File Copy
            Stopwatch sw = Stopwatch.StartNew();
            BufferedFileCopy.CopyWithoutBuffer(sourceFile, destUnbuffered);
            sw.Stop();
            Console.WriteLine($"Unbuffered Copy Time: {sw.ElapsedMilliseconds} ms");

            // Measure time for Buffered File Copy
            sw.Restart();
            BufferedFileCopy.CopyWithBuffer(sourceFile, destBuffered);
            sw.Stop();
            Console.WriteLine($"Buffered Copy Time: {sw.ElapsedMilliseconds} ms");

            Console.WriteLine("\n File copy completed. Compare times!");
        }

        //Read User Input from Console 
        public void CallingUserInput()
        {
            UserInputToFile.SaveData();
        }

        //Serialization - Save and Retrieve an Object 

        public void CallingEmployeeManager()
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee(101, "Alice", "HR", 50000),
            new Employee(102, "Bob", "IT", 70000),
            new Employee(103, "Charlie", "Finance", 65000)
        };

            // Save Employees
            EmployeeManager.SaveEmployees(employees);

            // Load Employees
            List<Employee> loadedEmployees = EmployeeManager.LoadEmployees();

            // Display Employees
            Console.WriteLine("\n Retrieved Employees:");
            foreach (var emp in loadedEmployees)
            {
                Console.WriteLine(emp);
            }
        }

        //ByteArray Stream - Convert Image to ByteArray 

        public void CallingImage()
        {
            string inputImagePath = @"C:\Users\JYOTI THAKUR\Desktop\input.jpeg";  // Original Image
            string outputImagePath = @"C:\Users\JYOTI THAKUR\Desktop\output.jpeg"; // New Image

            try
            {
                // Convert Image to Byte Array
                byte[] imageBytes = ImageConvertor.ConvertImageToByteArray(inputImagePath);
                Console.WriteLine("Image converted to Byte Array successfully!");

                // Convert Byte Array back to Image
                ImageConvertor.SaveByteArrayAsImage(imageBytes, outputImagePath);
                Console.WriteLine("Image saved from Byte Array successfully!");
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error: " + ex.Message);
            }
        }

        //Filter Streams - Convert Uppercase to Lowercase
        public void CallingFilter()
        {
            FilterStreams.UpperToLower();
        }
        //Data Streams - Store and Retrieve Primitive Data
        public void CallingDataStream()
        {
            DataStreams.StoreData();
        }

        //Piped Streams - Inter-Thread Communication 
        public void CallingPiped()
        {
            PipedStreams.ThreadCommunication();
        }

        //Read a Large File Line by Line
        public void CallingLargeFile()
        {
            LargeFile.ReadFile();
        }

        //Count words in a file
        public void CallingCountWords()
        {
            CountWords.Counter();
        }
    }
}
