using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace nilnul.os.ui
{
	public static class _TitleX
	{
		[DllImport("user32.dll")]
		public static extern bool SetWindowText(IntPtr hWnd, string text);

		[Obsolete()]
		public static void Void_ofNotNilHandle(IntPtr hWnd,string title)
		{
				SetWindowText(hWnd, title); 
		}

		public static void Void(IntPtr hWnd,string title)
		{
			if (hWnd != IntPtr.Zero)
			{
				nilnul.os.ui_.nonnil._TitleX.Act(hWnd, title);
			}
		}
	}
}