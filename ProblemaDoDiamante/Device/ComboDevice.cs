﻿using System;
using System.Reflection.Metadata;


namespace HerancaMultipla.Device
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice Processing " + document);
        }

        public string Scan()
        {
            return "ComboDevice Scan result " ;
        }
    }
}
