using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class UsingStatement
    {

        public static void FileHandling()
        {
            string filePath = "info.txt";

            try
            {
                // Using statement ensures automatic file closing
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string firstLine = reader.ReadLine();
                    Console.WriteLine("First Line: " + firstLine);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file");
            }
        }
    }

}

