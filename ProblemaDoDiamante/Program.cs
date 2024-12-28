/* A herança múltipla pode gerar o problema do diamante
 * uma ambiguidade causada pela existência do memso método em mais de uam superclasse
 * Herança múltipla não é permitida na maioria das linguagens
 */


using HerancaMultipla.Device;
using System;

namespace HerancaMultipla
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Printer printer = new Printer()
            {
                SerialNumber = 1080
            };
            printer.ProcessDoc("My letter");
            printer.Print("My letter");


            Scanner scanner = new Scanner()
            {
                SerialNumber = 2003
            };
            scanner.ProcessDoc("My Email");
            Console.WriteLine(scanner.Scan());

            ComboDevice device = new ComboDevice()
            {
                SerialNumber = 3921
            };
            device.ProcessDoc("My dissertation ");
            device.Print("My dissertation");
            Console.WriteLine(device.Scan());
            
        }
    }
}
