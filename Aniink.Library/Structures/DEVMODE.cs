using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aniink.Library.Structures
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Auto)]
    internal struct DM_DOTNET
    {
        private const int CCHDEVICENAME2 = 32;
        private const int CCHFORMNAME2 = 32;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME2)]
        public string dmDeviceName;
        public Int16 dmSpecVersion;
        public Int16 dmDriverVersion;
        public Int16 dmSize;
        public Int16 dmDriverExtra;
        public DM dmFields;

        public Int16 dmOrientation;
        public Int16 dmPaperSize;
        public Int16 dmPaperLength;
        public Int16 dmPaperWidth;
        public Int16 dmScale;
        public Int16 dmCopies;
        public Int16 dmDefaultSource;
        public Int16 dmPrintQuality;

        public Point dmPosition;
        public Int32 dmDisplayOrientation;
        public Int32 dmDisplayFixedOutput;

        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME2)]
        public string dmFormName;
        public Int16 dmLogPixels;
        public Int32 dmBitsPerPel;
        public Int32 dmPelsWidth;
        public Int32 dmPelsHeight;
        public Int32 dmDisplayFlags;
        //public Int32 dmNup;
        public Int32 dmDisplayFrequency;
    }
}
