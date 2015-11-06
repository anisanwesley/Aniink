using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniink.Library
{
    public class Printer
    {
        public int Index{ get; set; }
        public string Name { get; set; }
        public bool Open { get; set; }
        public IntPtr Pointer { get; internal set; }
    }
}
