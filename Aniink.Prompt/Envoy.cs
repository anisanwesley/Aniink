using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aniink.Library;

namespace Aniink.Prompt
{
    public static class Envoy
    {
        

        internal static Printer ChoosePrinter(List<Printer> printers)
        {
            cw("Escolha a Impressora:");

            foreach (var p in printers)
                cw(String.Format("{0}: {1}",p.Index,p.Name));

            var i = cn;

            return printers.Find(p=>p.Index==i);

        }


        #region Shorcuts

        private static void cw(object obj) { Console.WriteLine(obj); }
        private static string cr { get { return Console.ReadLine(); } }
        private static double cn { get { return Convert.ToDouble(Console.ReadLine()); } }

        #endregion
    }
}
