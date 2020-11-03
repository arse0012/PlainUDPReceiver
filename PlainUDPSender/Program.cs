using System;

namespace PlainUDPSender
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPSender sender = new UDPSender();
            sender.Start();


            //Console.WriteLine("Hello World!");
        }
    }
}
