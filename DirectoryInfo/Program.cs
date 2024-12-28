// Directory
// tem operaçoes estatitas(simple, but perfoms security check dor each operation)
//DirectoryInfo
// instance members

using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoreyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\myfolder";

            try
            {   // Pegar todas as pastas apartir de uam sub pasta(Myfolder)
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // *.* buscar qualquer tipo de arquivo
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders) 
                {
                    Console.WriteLine(s);
                }
                // Buscar itens na pastas da subpasta
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // *.* buscar qualquer tipo de arquivo
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                // Criar pasta na Subpasta
                Directory.CreateDirectory(path + @"\newfolder");



            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}

// se eu qser usar o DirectyInfo e so usar  como usei o FileInfo. funciona da mesma forma
