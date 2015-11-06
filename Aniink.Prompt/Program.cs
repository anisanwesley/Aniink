using Aniink.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniink.Prompt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var text = ""; text != "exit";text = Console.ReadLine())
            {

                var man = new Manager();

                var printer = Envoy.ChoosePrinter(man.Printers);

                var info2 = man.GetPrinter(printer);

                Envoy.PrintInfo(info2);

                Console.WriteLine(printer.Name);

                man.DocumentProperties

                Console.Write("\n'exit' para sair\n>");

            }
        }
    }
}
