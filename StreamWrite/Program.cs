/*
   È uma stream capaz de escrever caracteres a partir de uma stream binária (Ex: FileStream)
   Suporte a dados no formato de texto.
*/
using System;
using System.IO;

namespace StreamWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\Nova\file1.txt";
            string targetPath = @"c:\Nova\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath)) 
                {
                    foreach (string line in lines) 
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error Occurred: " + e.Message);
            }
        }

    }
}