using System;
using System.IO;

namespace FileStreamStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Nova\file1.txt";

            StreamReader sr = null;

            try
            {

                sr = File.OpenText(path);
                while (!sr.EndOfStream) // como ler todo o arquivo
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error Occurred: " + e.Message);
            }

            finally
            {

                if (sr != null) sr.Close();// pra fechar o arquivo precisamos usar o nome do arquivo.close
               


            }
        }
    }
}
