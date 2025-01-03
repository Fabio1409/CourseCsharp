﻿using System;
using System.IO;
namespace FileSystem
{
    class program
    {
        public static void Main(string[] args)
        {
            string sourcePath = @"c:\Nova\file1.txt";
            string targetPath = @"c:\Nova\file2.txt";


            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines) 
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}