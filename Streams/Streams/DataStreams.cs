using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class DataStreams
    {
            public static void StoreData()
            {
                string filePath = @"C:\Users\JYOTI THAKUR\Desktop\students.dat";

                try
                {
                    // Store Student Data
                    StoreStudentData(filePath);

                    // Retrieve Student Data
                    RetrieveStudentData(filePath);
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

            static void StoreStudentData(string filePath)
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    // Writing 3 student records
                    writer.Write(101); writer.Write("Alice"); writer.Write(3.8);
                    writer.Write(102); writer.Write("Bob"); writer.Write(3.6);
                    writer.Write(103); writer.Write("Charlie"); writer.Write(3.9);
                }

                Console.WriteLine("Student data stored successfully!");
            }

            static void RetrieveStudentData(string filePath)
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine(" Error: File not found!");
                    return;
                }

                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    Console.WriteLine("\n Retrieved Student Data:");
                    while (fs.Position < fs.Length)
                    {
                        int roll = reader.ReadInt32();
                        string name = reader.ReadString();
                        double gpa = reader.ReadDouble();
                        Console.WriteLine($"ID: {roll}, Name: {name}, GPA: {gpa:F2}");
                    }
                }
            }
        
}
}
