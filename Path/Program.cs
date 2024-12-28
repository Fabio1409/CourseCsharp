// Realiza operações com strings que contém informações de arquivos.

using System;
using System.IO;
using System.Collections.Generic;


namespace PatH
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"c:\myfolder\Nova\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("GetDirectotyName: " + Path.GetDirectoryName(path));
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));// pegar o caminho todo do arquivo
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            
        }
    }
}
