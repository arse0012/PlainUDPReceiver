using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ModelLib;

namespace PlainUDPReceiver
{
    public class UDPReceiver
    {
        public UDPReceiver()
        {
            
        }
        public void Start()
        {
            UdpClient client = new UdpClient();
            Car car = new Car("Tesla", "Red","EL3421");

            byte[] buffer;
            
            // Sender
            IPEndPoint modtagerEP = new IPEndPoint(IPAddress.Loopback, 11001);
            string str = car.ToString();
            byte[] outbuffer = Encoding.UTF8.GetBytes(str.ToCharArray());
            client.Send(outbuffer, outbuffer.Length, modtagerEP);


            // Modtager
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
            buffer = client.Receive(ref remoteEP);

            Console.WriteLine($"Har modtaget en bil kommer fra IP {remoteEP.Address} og port {remoteEP.Port}");
            string incommingstr = Encoding.UTF8.GetString(buffer);

            Console.WriteLine("tekst modtaget = " + incommingstr);
        }
    }
}
