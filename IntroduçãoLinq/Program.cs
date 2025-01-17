/* LINK - Language Integrated Query
 * 
 * É um conjunto de tecnologias baseadas na integração de funcionalidades de consultas diretamente
 * na linguagem C#.
 * Operações Chamadas diretamente a partir das coleções.
 * Consultas são objetos de ´rimeira classe.
 * Namespace: System.Linq
 * 
 * Possui deversas operações de consulta, cujos parâmetros tipicamente são expressões 
 * lambda ou exprrssões de sintaxe similar á SQL.
 */

using System.Linq;

namespace IntroduçãoLinq
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Specify the data source

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            // Difine the query expression

            var result = numbers.Where(X => X % 2 == 0).Select(X => X * 10);

            // Execute the query

            foreach ( var number in result )
            {
                Console.WriteLine(number);
            }
        }
    }
}
