using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class FilterStreams
    {
            public static void UpperToLower()
            {
                string inputFile = @"C:\Users\JYOTI THAKUR\Desktop\Source.txt";   // Original File
                string outputFile = @"C:\Users\JYOTI THAKUR\Desktop\output.txt"; // Converted File

                if (!File.Exists(inputFile))
                {
                    Console.WriteLine(" Error: Input file not found!");
                    return;
                }

                try
                {
                    using (FileStream fsRead = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                    using (BufferedStream bsRead = new BufferedStream(fsRead))
                    using (StreamReader reader = new StreamReader(bsRead, Encoding.UTF8)) 
                    using (FileStream fsWrite = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                    using (BufferedStream bsWrite = new BufferedStream(fsWrite))
                    using (StreamWriter writer = new StreamWriter(bsWrite, Encoding.UTF8)) // Ensure proper encoding
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            writer.WriteLine(line.ToLower());  // Convert to lowercase
                        }
                    }

                    Console.WriteLine(" File converted successfully!");
                    Console.WriteLine("Converted file saved at: " + outputFile);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(" IOException: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }


