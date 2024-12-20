using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoAbstratos.Entities
{
    public abstract class PessoaFisica 
    {
        public  PessoaFisica() { }

        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public double GastoSaude { get; set; }

        public PessoaFisica(string nome, double gastoAnual,double rendaAnual, double gastoSaude)
        {
            Nome = nome;
            GastoSaude = gastoSaude;
            RendaAnual = rendaAnual;

        }
        public virtual double 
    }
}
