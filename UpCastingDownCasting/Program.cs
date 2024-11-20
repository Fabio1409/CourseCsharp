
//(Casting) Converter uma variavel para outro tipo
// Casting da subclass para superclasse

// DownCasting da superclasse para subclass
using UpCastingDownCasting.Entities;

namespace UpCastingDownCasting
{
    class Program
    {
        public static void Main(string[] args)
        { 
            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Jose Fabio", 2000.0, 500.0);

            // UPCASTING
            
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Patricia", 0.00, 200.0);
            Account acc3 = new SavingsAccount(1004,"Anna", 0.00, 0.01);

            //  DOWNCASTING
            BusinessAccount  acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }


        }
    }
}

