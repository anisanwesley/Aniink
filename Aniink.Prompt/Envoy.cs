using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aniink.Library;
using Aniink.Library.Structures;

namespace Aniink.Prompt
{
    public static class Envoy
    {


        internal static Printer ChoosePrinter(List<Printer> printers)
        {
            cw("\nEscolha a Impressora:");

            foreach (var p in printers)
                cw(String.Format("{0}: {1}", p.Index, p.Name));

            var i = cn;

            return printers.Find(p => p.Index == i);

        }

        internal static void PrintInfo(PRINTER_INFO_2 info2)
        {

            cw("Attributes: ".PadRight(25) + info2.Attributes);
            cw("AveragePPM: ".PadRight(25) + info2.AveragePPM);
            cw("cJobs: ".PadRight(25) + info2.cJobs);
            cw("DefaultPriority: ".PadRight(25) + info2.DefaultPriority);
            cw("pComment: ".PadRight(25) + info2.pComment);
            cw("pDatatype: ".PadRight(25) + info2.pDatatype);
            cw("pDevMode: ".PadRight(25) + info2.pDevMode);
            cw("pDriverName: ".PadRight(25) + info2.pDriverName);
            cw("pLocation: ".PadRight(25) + info2.pLocation);
            cw("pParameters: ".PadRight(25) + info2.pParameters);
            cw("pPortName: ".PadRight(25) + info2.pPortName);
            cw("pPrinterName: ".PadRight(25) + info2.pPrinterName);
            cw("pPrintProcessor: ".PadRight(25) + info2.pPrintProcessor);
            cw("Priority: ".PadRight(25) + info2.Priority);
            cw("pSecurityDescriptor: ".PadRight(25) + info2.pSecurityDescriptor);
            cw("pSepFile: ".PadRight(25) + info2.pSepFile);
            cw("pServerName: ".PadRight(25) + info2.pServerName);
            cw("pShareName: ".PadRight(25) + info2.pShareName);
            cw("StartTime: ".PadRight(25) + info2.StartTime);
            cw("Status: ".PadRight(25) + info2.Status);
            cw("UntilTime: ".PadRight(25) + info2.UntilTime);

        }


        #region Shorcuts

        private static void cw(object obj) { Console.WriteLine(obj); }
        private static string cr { get { return Console.ReadLine(); } }
        private static double cn {
            get
            {
                try {
                    return Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException) {
                    cw("FormatException - Tente novamente");
                    return cn;
                }

            }
        }

        #endregion
    }
}
