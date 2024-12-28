using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';  // codigo unicode
            //SByte x = 100;
            // Console.WriteLine(x);
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;// Sempre usar o L no final pra recoemndar que e uam variavel longa.
            float n5 = 45.3f;
            double n6 = 45.3;
            string nome = "Maria green"; // objeto aceita qualquer tipo de type variavel
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            Console.WriteLine(obj2);
            Console.WriteLine(obj1);
            Console.WriteLine(nome);
            Console.WriteLine(n6);
            Console.WriteLine(n5);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);// CW junto com tab cria print..
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine("");
            Console.WriteLine("Te amor C#");
            Console.WriteLine("");

            int t1 = int.MinValue;  // menor valor do int.
            Console.WriteLine(t1);
            int t2 = int.MaxValue;
            Console.WriteLine(t2);

            sbyte t3 = sbyte.MinValue;  // saber quanto aceita cada type
            Console.WriteLine(t3);
            sbyte t4 = sbyte.MaxValue;
            Console.WriteLine(t4);

            decimal t5 = decimal.MinValue;
            Console.WriteLine(t5);
            decimal t6 = decimal.MaxValue;
            Console.WriteLine(t6);

            // restricoes para nomes de variaveis
            // nao pode começar  com digito: use uma letra ou _
            // nao usar acentos
            // nao pode ter espaços em branco 
            //segestao: use nomes que tenham um significado para variaveis 

            // Camel Case: lastName (Parãmetros de métodos,variaveis dentro de metodos)
            // PascalCase: Last Name (namespaces, classe,properties e metodos)
            // Padrão _LastName (atributos "internos" da classe)

            // Saída de dados em C#

            // Comandos
            // console.writeLine(valor); = coloca quebra de linha na impressao
            // console.write(valor); imprime na frente sem quebra de linhas
            Console.Write("Bom dia!");
            Console.WriteLine("Boa Tarde!!");
            Console.WriteLine("Boa Noite!!");

        }

    }
}
