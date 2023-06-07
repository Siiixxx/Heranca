using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount businessAccount = new BusinessAccount(8010,"Bob Brown",100.0,500.0);
            Console.WriteLine(businessAccount.Balance);

        }
    }
}