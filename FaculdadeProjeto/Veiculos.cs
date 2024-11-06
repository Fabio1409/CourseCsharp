using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaculdadeProjeto
{
    public class Veiculos
    {
        public Marca marca { get; set; }
        public string Modelo { get; set; }
        public Cor Cor { get; set; }
        public bool Teto { get; set; }
        public int Portas { get; set; }

        private string RemoverAirbarg { get; set; }

        public DateTime TrocaDeOleo { get; set; }

        public string Seguranca()
        {
            RemoverAirbarg = "Item de segurança dp veiculo nao pode ser retirado!";
            return "Remoção de airbarg proibida";
        }
        public string PegarEstadoDoAibarg()
        {
            return RemoverAirbarg;
        }

    }
    public enum Cor
    {
        yellow,
        red,
        blue,
        grey,
        green,
        pink
    }
    public enum Marca
    {
        Volksvagem,
        Nissan,
        Toyota,
        Fiat,
        BYD,
        Ford,
        Chevrolet,
        Peugout,
        Mistsubishi,
        Hiunday,
        Honda,
        Renault,
        Citroen,
        BMW,
        Audi,
        Porshe,
        Mazda
    }
}
