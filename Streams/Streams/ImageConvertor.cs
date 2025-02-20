using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class ImageConvertor
    {
   
            // Convert Image File to Byte Array
            public static byte[] ConvertImageToByteArray(string imagePath)
            {
                if (!File.Exists(imagePath))
                    throw new FileNotFoundException(" Image file not found!");

                return File.ReadAllBytes(imagePath);
            }

            //  Convert Byte Array back to Image File
            public static void SaveByteArrayAsImage(byte[] imageBytes, string outputPath)
            {
                File.WriteAllBytes(outputPath, imageBytes);
            }
        }
    }


