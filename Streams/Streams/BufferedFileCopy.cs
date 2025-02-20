using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class BufferedFileCopy
    {
        // Unbuffered File Copy (Slow)
        public static void CopyWithoutBuffer(string source, string destination)
        {
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
            {
                int byteRead;
                while ((byteRead = fsRead.ReadByte()) != -1)
                {
                    fsWrite.WriteByte((byte)byteRead);  // Writing byte by byte (VERY SLOW)
                }
            }
        }

        //  File Copy (Fast)
        public static void CopyWithBuffer(string source, string destination)
        {
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (BufferedStream bsRead = new BufferedStream(fsRead, 4096))
            using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite, 4096))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bsWrite.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}
