using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.ui
{
	internal class _ExtensionsX
	{
		/// <summary>
		/// Win32 API Imports
		/// </summary>
		[DllImport("user32.dll")]
		private static extern
			bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
		[DllImport("user32.dll")]
		private static extern
			bool SetForegroundWindow(IntPtr hWnd);
		[DllImport("user32.dll")]
		private static extern
			bool IsIconic(IntPtr hWnd);
		[DllImport("user32.dll")]
		private static extern
			bool IsZoomed(IntPtr hWnd);
		[DllImport("user32.dll")]
		private static extern
			IntPtr GetForegroundWindow();
		[DllImport("user32.dll")]
		private static extern
			IntPtr GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);
		[DllImport("user32.dll")]
		private static extern
			IntPtr AttachThreadInput(IntPtr idAttach, IntPtr idAttachTo, int fAttach);



		//delegate used for EnumWindows() callback function
		public delegate bool EnumWindowsProc(int hWnd, int lParam);

		/// <summary>
		/// Win32 API Imports
		/// </summary>
		[DllImport("user32.dll")] private static extern 
              int GetWindowText(int hWnd, StringBuilder title, int size);
        [DllImport("user32.dll")] private static extern 
              int GetWindowModuleFileName(int hWnd, StringBuilder title, int size);
        [DllImport("user32.dll")] private static extern 
              int EnumWindows(EnumWindowsProc ewp, int lParam); 
        [DllImport("user32.dll")] private static extern 
              bool IsWindowVisible(int hWnd);

	}
}
