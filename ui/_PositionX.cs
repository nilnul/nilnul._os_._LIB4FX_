using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Runtime.InteropServices;

namespace nilnul.os.ui
{
	public class _PositionX
	{
		public const int HWND_BOTTOM = 1;

		public const uint SWP_NOSIZE = 1u;

		public const uint SWP_NOMOVE = 2u;

		public const uint SWP_SHOWWINDOW = 64u;

		public const uint SWP_NOACTIVATE = 16u;

		public const uint SWP_NOZORDER = 4u;

		public const int SWP_HIDEWINDOW = 128;

		[DllImport("user32.dll")]
		public static extern bool SetWindowPos(int hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		public static void ShoveToBackground(int handle)
		{
			SetWindowPos(handle, 1, 0, 0, 0, 0, 83u);
		}

		public static void ShoveToBackground(IntPtr mainWindowHandle)
		{
			ShoveToBackground((int)mainWindowHandle);
		}
	}
}
