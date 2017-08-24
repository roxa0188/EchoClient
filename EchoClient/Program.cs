using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace EchoClient
{
    class Program
    {
        static bool programRunning = true;
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("127.0.0.1", 5000);
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());
            sw.AutoFlush = true;


            while (programRunning)
            {

                sw.WriteLine(Console.ReadLine());
                string data = sr.ReadLine();
                Console.WriteLine(data);

            }
        }
    }
}
