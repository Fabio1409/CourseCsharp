

namespace ExercicioFixacaoAbstratos.Entities
{
    public class PessoaJuridica : PessoaFisica
    {
        public int NumeroFuncionario { get; set; }

        public PessoaJuridica(string nome, double gastoSaude, double gastoAnual,double rendaAnual, int numeroFuncionario)
            : base(nome, gastoSaude, gastoAnual,rendaAnual)
        {
            NumeroFuncionario = numeroFuncionario;
        }
    }
}
