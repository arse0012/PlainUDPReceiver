using System;

namespace JsonUDPReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPReceiver receiver = new UDPReceiver();
            receiver.Start();


            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
