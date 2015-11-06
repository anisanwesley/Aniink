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

        public IntPtr GetDevMode(Printer printer)
        {
            int sizeNeeded = DocumentProperties(IntPtr.Zero, printer.Pointer, printer.Name, IntPtr.Zero, IntPtr.Zero, fModes.DM_SIZEOF);
            if (sizeNeeded < 0)
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }

            // not really required, but see example: http://support.microsoft.com/kb/828638/en-us
            sizeNeeded += 100;

            IntPtr pdevmode = Marshal.AllocHGlobal(sizeNeeded);

            int result = DocumentProperties(IntPtr.Zero, printer.Pointer, printer.Name, pdevmode, IntPtr.Zero, fModes.DM_OUT_BUFFER);
            if (result < 0)
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }

            Marshal.FreeHGlobal(printer.Pointer);

            return pdevmode;
        }

        void OpenPrinterPropertiesDialog(PrinterSettings printerSettings)
        {
            IntPtr hDevMode = printerSettings.GetHdevmode(printerSettings.DefaultPageSettings);
            IntPtr pDevMode = GlobalLock(hDevMode);
            int sizeNeeded = DocumentProperties(IntPtr.Zero, IntPtr.Zero, printerSettings.PrinterName, IntPtr.Zero, pDevMode, 0);
            IntPtr devModeData = Marshal.AllocHGlobal(sizeNeeded);
            DocumentProperties(IntPtr.Zero, IntPtr.Zero, printerSettings.PrinterName, devModeData, pDevMode, 14);
            GlobalUnlock(hDevMode);
            printerSettings.SetHdevmode(devModeData);
            printerSettings.DefaultPageSettings.SetHdevmode(devModeData);
            GlobalFree(hDevMode);
        }

        public int DocumentProperty(Printer printer)
        {
            return DocumentProperties(IntPtr.Zero,printer.Pointer,printer.Name, IntPtr.Zero, IntPtr.Zero, (fModes)14);
        }
    }
}
