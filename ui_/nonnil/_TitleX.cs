using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace nilnul.os.ui_.nonnil
{
	public static class _TitleX
	{


			///If the function succeeds, the return value is nonzero.
		[DllImport("user32.dll")]
		public static extern bool SetWindowText(IntPtr hWnd, string text);

		public static void Act(IntPtr hWnd,string title)
		{

			if (!SetWindowText(hWnd, title))
			{
				Trace.TraceError($"setting title:{title} of {hWnd} failed;");
			} 
		}
	}
}
