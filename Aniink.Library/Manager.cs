using Aniink.Library.Structures;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniink.Library
{
    public partial class Manager
    {
        public List<Printer> Printers { get; private set; }

        public Manager()
        {
            Printers = new List<Printer>();

            var index = 0;
            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                var pointer = new IntPtr();
                var open = OpenPrinter(printerName, out pointer, new PRINTER_DEFAULTS());

                Printers.Add(new Printer
                {
                    Index = ++index,
                    Name = printerName,
                    Pointer = pointer
                });
            }

        }
    }
}
