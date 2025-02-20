using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class LargeFile
    {
    
            public  static void ReadFile()
            {
                string filePath = @"C:\Users\JYOTI THAKUR\Desktop\largefile.txt.txt"; // Change this to your actual file path

                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)  // Read line-by-line
                        {
                            if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)  // Case insensitive search
                            {
                                Console.WriteLine(line);  // Print only lines containing "error"
                            }
                        }
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("IOException: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }

