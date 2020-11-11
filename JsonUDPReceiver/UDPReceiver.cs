using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Channels;
using ModelLib;
using Newtonsoft.Json;

namespace JsonUDPReceiver
{
    public class UDPReceiver
    {
        public UDPReceiver()
        {
            
        }
        public void Start()
        {
            UdpClient client = new UdpClient(11002);

            byte[] buffer;

            while (true)
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                buffer = client.Receive(ref remoteEP);
                string jsonStr = Encoding.UTF8.GetString(buffer);
                Car car = JsonConvert.DeserializeObject<Car>(jsonStr);

                Console.WriteLine("Bil modtaget: \n" + car);

                byte[] outbuffer = Encoding.UTF8.GetBytes(car.ToString());
                client.Send(outbuffer, outbuffer.Length, remoteEP);
            }

        }
    }
}
