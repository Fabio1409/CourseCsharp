

namespace Heranca.Entities
{
    internal class Account
    {
        public int Number { get; private set; }//Numero conta
        public string Holder { get; private set; }// Titular conta
        public double Balance { get; protected set; }// Saldo conta, posso usar o protected para alterar o valores em uma subclasse

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
