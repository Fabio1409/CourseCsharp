using System;
using System.Globalization;
namespace Ternaria
{
    class Program
    {
        static void Main(string[] args)
        {
            /* double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.5;
             Console.WriteLine(desconto);
            */

            var original = "abcde FGHIJ ABC abc DEFG  ";
            var s1 = original.ToUpper();
            var s2 = original.ToLower();
            var s3 = original.Trim();
            var n1 = original.IndexOf("bc");
            var n2 = original.LastIndexOf("bc");
            var s6 = original.Replace('a', 'x');
            var s7 = original.Replace("abc", "xy");
            var s4 = original.Substring(3);
            var s5 = original.Substring(3, 5);
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper : -" + s1 + "-");
            Console.WriteLine("ToLower : -" + s2 + "-");
            Console.WriteLine("Trim : -" + s3 + "-"); // apaga os espaços em branco deixado na variavel .
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring('3'): " + s4);
            Console.WriteLine("Substring('3, 5'): " + s5);
            Console.WriteLine("Replace (a por x): " + s6);
            Console.WriteLine("Replace (abc por xy): " + s7);
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}

