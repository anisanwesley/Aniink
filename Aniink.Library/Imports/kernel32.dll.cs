using Aniink.Library.Enums;
using Aniink.Library.Structures;
using System;
using System.Runtime.InteropServices;

namespace Aniink.Library
{
    public partial class Manager
    {
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GlobalUnlock(IntPtr hMem);

        [DllImport("kernel32.dll")]
        static extern IntPtr GlobalLock(IntPtr hMem);

        [DllImport("kernel32.dll")]
        static extern IntPtr GlobalFree(IntPtr hMem);
    }
}
