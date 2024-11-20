using System;
using Heranca.Entities;

namespace Heranca
{
    class program
    {
        public static void Main(string[] args)
        {
            BusinessAcount account = new BusinessAcount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);
        }
   }
}



