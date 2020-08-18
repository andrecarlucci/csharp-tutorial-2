using System;

namespace Bank.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var from = new Account(10);
            var to = new Account(10);

            from.Tranfer(1, to);

            Console.WriteLine("-> " + to.Balance);
            
        }
    }
}
