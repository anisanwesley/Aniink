using Aniink.Library.Enums;
using Aniink.Library.Structures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
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
               // var open = OpenPrinter(printer.Name, out pointer, new PRINTER_DEFAULTS());

                Printers.Add(new Printer
                {
                    Index = ++index,
                    Name = printerName,
                    Pointer = pointer
                });
            }

        }
        /// <summary>
        /// Get Printer Info
        /// </summary>
        /// <param name="printer"></param>
        /// <returns></returns>
        public PRINTER_INFO_2 GetPrinter(Printer printer)
        {
            IntPtr pHandle;
            PRINTER_INFO_2 Info2 = new PRINTER_INFO_2();
            PRINTER_DEFAULTS defaults = new PRINTER_DEFAULTS();
            OpenPrinter(printer.Name, out pHandle, defaults);
            uint cbNeeded = 0;

            bool bRet = GetPrinter(pHandle, 2, IntPtr.Zero, 0, ref cbNeeded);
            if (cbNeeded > 0)
            {
                IntPtr pAddr = Marshal.AllocHGlobal((int)cbNeeded);
                bRet = GetPrinter(pHandle, 2, pAddr, cbNeeded, ref cbNeeded);
                if (bRet)
                {
                    
                    Info2 = (PRINTER_INFO_2)Marshal.PtrToStructure(pAddr, typeof(PRINTER_INFO_2));
                }
                Marshal.FreeHGlobal(pAddr);

            }

            ClosePrinter(pHandle);
            return Info2;
        }

        public bool SetDefaultPrinter(Printer printer)
        {
            return SetDefaultPrinter(printer.Name);
        }

        /// <summary>
        /// Open printer's properties dialog
        /// </summary>
        /// <param name="printer"></param>
        /// <returns></returns>
        public int DocumentProperty(Printer printer)
        {
            return DocumentProperties(IntPtr.Zero, printer.Pointer, printer.Name, IntPtr.Zero, IntPtr.Zero, (fModes)14);
        }

        public bool FlushPrinter(Printer printer)
        {
            int i=0;
            var result = FlushPrinter(printer.Pointer,IntPtr.Zero,0,out i,1000);
            return result;

        }
    }
}
