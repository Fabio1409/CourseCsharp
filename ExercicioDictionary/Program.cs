/* EXTENSION METHODS
 * São métodos que estendem a funcionalidade de um tipo, sem
 * precisar alterar o código fonte deste tipo, nem herdar desse tipo
 * 
 * Como Fazer um Extension method?
 * 
 * Criar uma class estática
 * Na class, criar um metodo estático
 * O primeiro parâmetro do método deverá ter o prefixo this, seguido da declaração de um 
 * parâmetro de tipo que se deseja estender. Esá será uma referência para o proprio objeto.
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using ExtensionMethods.Extensions;

namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2025, 01, 5, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students! ";
            Console.WriteLine(s1.Cut(10));
        }
    }
}

