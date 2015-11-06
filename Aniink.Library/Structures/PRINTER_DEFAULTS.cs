using Aniink.Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aniink.Library.Structures
{
    /// <summary>
    /// The PRINTER_DEFAULTS structure specifies the default data type,
    /// environment, initialization data, and access rights for a printer.
    /// </summary>
    /// <seealso href="http://msdn.microsoft.com/en-us/library/windows/desktop/dd162839(v=vs.85).aspx"/>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal class PRINTER_DEFAULTS
    {
        /// <summary>
        /// Pointer to a null-terminated string that specifies the 
        /// default data type for a printer.
        /// </summary>
        public IntPtr pDatatype;

        /// <summary>
        /// Pointer to a DEVMODE structure that identifies the 
        /// default environment and initialization data for a printer.
        /// </summary>
        public IntPtr pDevMode;

        /// <summary>
        /// Specifies desired access rights for a printer. 
        /// The <see cref="OpenPrinter(string, out IntPtr, IntPtr)"/> function uses
        /// this member to set access rights to the printer. These rights can affect 
        /// the operation of the SetPrinter and DeletePrinter functions.
        /// </summary>
        public ACCESS_MASK DesiredAccess;
    }
}
