using System.Globalization;

namespace exercicio02
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double SaldoConta { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;


        }
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }
        public void Deposito(double quantia)
        {
            SaldoConta += quantia;

        }
        public void Saque(double quantia)
        {
            SaldoConta -= quantia + 5;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
