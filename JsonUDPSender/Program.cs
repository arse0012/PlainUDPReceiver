using System;

namespace JsonUDPSender
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Start();


            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
