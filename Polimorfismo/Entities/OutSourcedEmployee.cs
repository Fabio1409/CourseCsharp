

namespace Exercicio.Entities
{
    internal class OutSourcedEmployee : Employee

    {
        public double AdditionalCharge { get; set; }
        public OutSourcedEmployee() 
        {
        }

        public OutSourcedEmployee (string name, int hours, double valorPerHour, double additionalCharge)
            : base(name, hours, valorPerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payments()
        {
            return base.Payments() + 1.1 * AdditionalCharge;
        }
    }
}
