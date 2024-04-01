using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UdpClient server = new UdpClient();
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 1234);

            while (true)
            {
                string time = DateTime.Now.ToString(); 
                byte[] data = Encoding.UTF8.GetBytes(time);
                server.Send(data, data.Length, endPoint);
                Thread.Sleep(1000); 
            }
        }
    }
}
