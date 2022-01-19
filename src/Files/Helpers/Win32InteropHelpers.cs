using System;
using System.Runtime.InteropServices;

namespace Files.Helpers
{
    public static class Win32InteropHelpers
    {
        [DllImport("Setupapi.dll", EntryPoint="InstallHinfSection", CallingConvention=CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        private static extern void InstallHinfSection([In] IntPtr hwnd, [In] IntPtr moduleHandle, [In, MarshalAs(UnmanagedType.LPWStr)] string cmdLineBuffer, int nCmdShow);

        public static void InstallInf(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return;

            InstallHinfSection(IntPtr.Zero, IntPtr.Zero, filePath, 0);
        }
    }
}