using System;

namespace PlainUDPReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPReceiver receiver = new UDPReceiver();
            receiver.Start();


            Console.WriteLine("Hello World!");
        }
    }
}
