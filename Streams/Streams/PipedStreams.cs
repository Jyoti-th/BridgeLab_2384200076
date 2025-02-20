using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Streams
{
    public class PipedStreams
    {
       
            public static void ThreadCommunication()
            {
            using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
            {
                string pipeHandle = pipeServer.GetClientHandleAsString();
                Console.WriteLine($"Writer Thread: Pipe Handle -> {pipeHandle}");

                Thread readerThread = new Thread(() => Reader(pipeHandle));
                readerThread.Start();

                try
                {
                    using (StreamWriter writer = new StreamWriter(pipeServer) { AutoFlush = true })
                    {
                        for (int i = 1; i <= 5; i++)
                        {
                            string message = $"Message {i} from Writer!";
                            writer.WriteLine(message);
                            Console.WriteLine($"📤 Sent: {message}");
                            Thread.Sleep(1000); // Simulate delay
                        }
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine(" Writer IOException: " + ex.Message);
                }

                readerThread.Join();
                Console.WriteLine("\n Data transfer completed successfully!");
            }
        }

        static void Reader(string pipeHandle)
        {
            try
            {
                using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeHandle))
                using (StreamReader reader = new StreamReader(pipeClient))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine($" Received: {line}");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Reader IOException: " + ex.Message);
            }
        }

    }
}


