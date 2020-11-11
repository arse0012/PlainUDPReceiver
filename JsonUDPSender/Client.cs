using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using ModelLib;
using Newtonsoft.Json;

namespace JsonUDPSender
{
    public class Client
    {
        public Client()
        {
            
        }
        public void Start()
        {
            UdpClient client = new UdpClient();

            byte[] buffer;

            // opretter en bil og laver en json string
            Car car = new Car("Tesla","Green","JsonCar4");
            string jsonString = JsonConvert.SerializeObject(car);

            // Sender 
            IPEndPoint modtagerEP = new IPEndPoint(IPAddress.Loopback, 11002);
            byte[] outbuffer = Encoding.UTF8.GetBytes(jsonString);
            client.Send(outbuffer, outbuffer.Length, modtagerEP);


            // Modtager
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
            buffer = client.Receive(ref remoteEP);
            string incommingstr = Encoding.UTF8.GetString(buffer);

            Console.WriteLine("tekst modtaget = " + incommingstr);
        }
    }
}
