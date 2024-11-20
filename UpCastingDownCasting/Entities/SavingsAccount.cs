

namespace UpCastingDownCasting.Entities
{
    internal class SavingsAccount:Account
    {
        public double IntersRate { get; set; }
        public SavingsAccount() 
        {
        }

        public SavingsAccount(int number, string holder, double balance, double intersRate)
            : base(number, holder, balance)
        {
            IntersRate = intersRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * IntersRate;
        }
    } 
    
}
