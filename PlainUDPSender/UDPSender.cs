using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ModelLib;

namespace PlainUDPSender
{
    public class UDPSender
    {
        public void Start()
        {
            Car car1 = new Car("Tesla", "red","EL23400");
            UdpClient socket = new UdpClient("Localhost", 11001);
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
            byte[] buffer = socket.Receive(ref remoteEP);

            string incommingstr = Encoding.UTF8.GetString(buffer);
            Console.WriteLine("modtager: " + incommingstr);

            socket.Send(buffer, buffer.Length, remoteEP);

        }
    }
}
