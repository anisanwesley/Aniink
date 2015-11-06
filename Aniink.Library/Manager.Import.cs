using Aniink.Library.Structures;
using System;
using System.Runtime.InteropServices;

namespace Aniink.Library
{
    public partial class Manager
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int OpenPrinter(string pPrinterName, out IntPtr phPrinter, PRINTER_DEFAULTS pDefault);

        [DllImport("winspool.drv", SetLastError = true)]
        static extern int OpenPrinter(string pPrinterName, out IntPtr phPrinter, IntPtr pDefault);

    }
}
