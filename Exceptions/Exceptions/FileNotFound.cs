using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class FileNotFound
    {

        public static void Found()
        {
            string filePath = "data.txt";

            try
            {
                // Attempt to read the file
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File Contents:\n" + content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while accessing the file: " + ex.Message);
            }
        }
    }

}

