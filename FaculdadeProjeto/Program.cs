using FaculdadeProjeto;
using System;

namespace ConsoleApp.Pratica1
{
    class Program
    {
        char char1 = 'A';

        static void Main(string[] args)
        {
            Console.WriteLine("Hello world - Aula Pratica 1!");
            Console.WriteLine("--------------------------------");

            int int1 = 10;
            Console.WriteLine($"{int1}");

            bool bool1 = false;
            bool bool2 = true;

            long long1 = 2555454544487955785;
            decimal decimal1 = 12545.54558525M;
            float f1 = 154214.45215f;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Tipos de reference Type");

            object obj1 = new object();
            var obj2 = new object();

            var obj3 = obj2;

            Console.WriteLine("Comparando objs");
            Console.WriteLine($"{obj1.GetType().Name} | {obj2.GetType().Name} | {obj3.GetType().Name}");
            Console.WriteLine($"{obj2 == obj3}");


            Console.WriteLine("--------------------------------");

            var s1 = new string('a', 5);
            string s2 = new string(new char[5] { 'a', 'a', 'a', 'a', 'a' });

            Console.WriteLine($"{s1 == s2}");

            string s3 = string.Concat((new char[5] { 'a', 'a', 'a', 'a', 'a' }).AsEnumerable());

            var s4 = $"{s3} string 3";

            Console.WriteLine($"{s4.ToString()}");



            ClasseCompareString compare1 = new ClasseCompareString()
            {
                testeComparacao = "123"
            };
            var compare2 = new ClasseCompareString()
            {
                testeComparacao = "123"
            };

            Console.WriteLine($"Comparando com == e com equals");

            Console.WriteLine($"{compare1 == compare2}");
            Console.WriteLine($"{compare1.testeComparacao == compare2.testeComparacao}");
            Console.WriteLine($"{compare1.testeComparacao.Equals(compare2.testeComparacao)}");

            Console.WriteLine("--------------------------------");
            ClasseComplexa classeComplexa = new ClasseComplexa();
            classeComplexa.PropInterface = 123;

            IImprimirValores interfaceX = classeComplexa;

            Console.WriteLine($"{interfaceX.PropInterface}");

            ClasseComplexa Rosinha = new ClasseComplexa();
            Rosinha.PropInterface = 24;


            Console.WriteLine($"{Rosinha.PropInterface}");



            ClasseComplexa Naruto = new ClasseComplexa();
            Naruto.MeuDecimal = 125424516;

            Veiculos T_Cross = new Veiculos();
            T_Cross.marca = Marca.Volksvagem;

            T_Cross.Modelo = "SUV";

            T_Cross.Cor = Cor.green;

            T_Cross.Portas = 5;

            T_Cross.TrocaDeOleo = DateTime.Now.AddDays(300);

            Console.WriteLine($"O carro e da marca {T_Cross.marca},de modelo {T_Cross.Modelo}, ele tem a cor {T_Cross.Cor}, com quantidade de portas {T_Cross.Portas}, e a proxima troca de oleo é {T_Cross.TrocaDeOleo.ToShortDateString()}");
            
            Console.WriteLine(T_Cross.Seguranca());
            Console.WriteLine(T_Cross.PegarEstadoDoAibarg());
        }
    }
}
