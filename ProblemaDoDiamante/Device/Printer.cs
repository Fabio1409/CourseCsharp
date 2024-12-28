using System;



namespace HerancaMultipla.Device
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Print Processing: " + document);

        }
        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
