using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Options
{
    public class NativeHelpers
    {
        [DllImport("kernel32.dll")]
        public static extern bool SetFileAttributes(string lpFileName, FileAttributes dwFileAttributes);
        //SetFileAttributes 

        [Flags]
        public enum FileAttributes : uint
        {
            Readonly = 0x00000001,
            Hidden = 0x00000002,
            System = 0x00000004,
        }

    }
}
