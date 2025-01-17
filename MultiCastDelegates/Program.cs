/*  Multicast delegates 
 *  
 *  Delegates que guardam a referência para mais de um método
 *  
 *  Para adicionar uma referência, pode-se usar o operador +=
 *  
 *  A chamada Invoker (ou sintaxe reduzida) executa todos os métodos na ordem em que foram adicionados
 *  
 *  Seu uso Faz sentido para métodos void
 */

using MultiCastDelegates.Services;
using System;

namespace MultiCastDelegates
{
    delegate void BinaryNumericOperation(double n1, double n2);// o que muda da aula passada e que agora e uma funçao void
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            op.Invoke(a, b);
            op(a, b);

        }

    }
}

