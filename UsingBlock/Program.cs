/*
    Sintaxe simplificada que garante que os objetos IDisposable serão fechados

    Objetos Idisposable Não gerenciados pelo CLR. Eles precisam ser manualmente fechados.
    Como: Font, FileStream, StreamReader, StreamWriter
*/


using System;
using System.IO;
using System.Linq.Expressions;


namespace UsingBlock
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"c:\Nova\file1.txt";
            try
            {
                //using (FileStream fs = new FileStream(path, FileMode.Open))
                //{
                    using (StreamReader sr = File.OpenText(path))// Codigo limpo
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }

               // }


            }
            catch (IOException e) 
            {
                Console.WriteLine("An error Occurred: " + e.Message);
            }
        }
    }
}


