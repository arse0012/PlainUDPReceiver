using System;
using System.Collections.Generic;
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

        }
    }
}
