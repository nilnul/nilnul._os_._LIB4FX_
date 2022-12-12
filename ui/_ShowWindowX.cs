using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace nilnul.os.ui

{


	/// <summary>
	/// </summary>
	public static class _ShowWindowX
	{

 [DllImport("user32.dll"
			//, ExactSpelling = true
			)] private static extern 
            bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
		//[DllImport("user32.dll")]
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		public static bool ShowWindow(IntPtr hWnd, _show.Command_ nCmdShow) {
			return ShowWindow(hWnd, (int)nCmdShow);
		}


	}
}
