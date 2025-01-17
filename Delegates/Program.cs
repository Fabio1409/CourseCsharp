/* Delegates
 * É uma referência ( com Type safety) para um ou mais métodos.
 * É um tipo de referência
 * 
 * Uso comuns:
 * Comunicação entre objetos de forma flexível e extensível (eventos / callbacbs)
 * Parametrização de operações por métodos (programação funcional)
 */

using Delegates.Services;
using System;

namespace Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args) 
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);// outra forma de fazer 

           // double result = op(a, b); // Forma que podemos usar tbm  
            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }

    }
}
 
