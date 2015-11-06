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
            var man = new Manager();

            var printer =  Envoy.ChoosePrinter(man.Printers);

            Console.WriteLine(printer.Name);

            Console.ReadLine();
        }
    }
}
