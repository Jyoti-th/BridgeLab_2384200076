using System;
using System.IO;

namespace Streams
{
    class ReadWrite
    {
        

        //CopyFile method should be outside Main, but inside Program class
        public static void CopyFile(string sourceFile, string destinationFile)
        {
            // Reading from the source file using FileStream
            using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fsRead))
            {
                string content = reader.ReadToEnd();

                // Writing to the destination file using FileStream
                using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fsWrite))
                {
                    writer.Write(content);
                }
            }
        }
    }
}
