using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniink.Library.Enums
{
    [Flags]
    public enum PRINTER_ATTRIBUTES
    { PRINTER_ATTRIBUTE_PUBLISHED =  1 << 8,

         /// <summary>
        /// If set, the printer spools and starts printing after the last page is
        /// spooled. If not set and PRINTER_ATTRIBUTE_DIRECT is not set, the printer
        /// spools and prints while spooling.
        /// </summary>
        [Description(@"If set, the printer spools and starts printing after the last page is
spooled. If not set and PRINTER_ATTRIBUTE_DIRECT is not set, the printer
spools and prints while spooling.")]
        QUEUED = 0x00000001,
        
        /// <summary>
        /// Job is sent directly to the printer (it is not spooled).
        /// </summary>
        [Description(@"Job is sent directly to the printer (it is not spooled).")]
        DIRECT = 0x00000002,
        
        /// <summary>
        /// Printer is default.
        /// </summary>
        [Description(@"Printer is default.")]
        DEFAULT = 0x00000004,

        /// <summary>
        /// Printer is shared.
        /// </summary>
        [Description(@"Printer is shared.")]
        SHARED = 0x00000008,
        
        /// <summary>
        /// Printer is a network printer connection.
        /// </summary>
        [Description(@"Printer is a network printer connection.")]
        NETWORK = 0x00000010,
        
        /// <summary>
        /// Reserved
        /// </summary>
        [Description(@"Reserved")]
        HIDDEN = 0x00000020,
        
        /// <summary>
        /// Printer is a local printer.
        /// </summary>
        [Description(@"Printer is a local printer.")]
        LOCAL = 0x00000040,
        
        /// <summary>
        /// If set, DevQueryPrint is called. DevQueryPrint may fail if the document and
        /// printer setups do not match. Setting this flag causes mismatched documents
        /// to be held in the queue.
        /// </summary>
        [Description(@"If set, DevQueryPrint is called. DevQueryPrint may fail if the document and
printer setups do not match. Setting this flag causes mismatched documents
to be held in the queue.")]
        ENABLE_DEVQ = 0x00000080,
        
        /// <summary>
        /// If set, jobs are kept after they are printed. If unset, jobs are deleted.
        /// </summary>
        [Description(@"If set, jobs are kept after they are printed. If unset, jobs are deleted.")]
        KEEPPRINTEDJOBS = 0x00000100,
        
        /// <summary>
        /// If set and printer is set for print-while-spooling, any jobs that have
        /// completed spooling are scheduled to print before jobs that have not
        /// completed spooling.
        /// </summary>
        [Description(@"If set and printer is set for print-while-spooling, any jobs that have
completed spooling are scheduled to print before jobs that have not
completed spooling")]
        DO_COMPLETE_FIRST = 0x00000200,

        [Description(@"If work offline.")]
        WORK_OFFLINE = 0x00000400,

        [Description(@"??")]
        ENABLE_BIDI = 0x00000800,
        /// <summary>
        /// Indicates that only raw data type print jobs can be spooled.
        /// </summary>
        [Description(@"Indicates that only raw data type print jobs can be spooled.")]
        RAW_ONLY = 0x00001000,

        /// <summary>
        /// Indicates whether the printer is published in the directory service.
        /// </summary>
        [Description(@"Indicates whether the printer is published in the directory service.")]
        PUBLISHED = 0x00002000,
    }

}
