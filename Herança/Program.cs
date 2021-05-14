using System;
using Herança.Entities;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 100.0);
            Account acc2 = new SavingsAccount(1002, "Jorge", 100.0, 0.01); //UPCASTING

            acc.WithDraw(10);
            acc2.WithDraw(10);

            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc2.Balance);


        }
    }
}
