using nilnul.os.ui._show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.ui_.hid.show_.normal_
{
	public static class _Min1inactiveX
	{
		public static void _assumeNonnil(IntPtr _hWnd)
		{
			/// for the first time, normal must be called;
			ui.show_._NormalX.Act(_hWnd);
			ui._ShowWindowX.ShowWindow(_hWnd, Command_.ShowMinNoActive);
		}

		public static void Act(IntPtr hWnd)
		{
			if (hWnd != IntPtr.Zero)
			{

				_assumeNonnil(hWnd);
			}
		}
	}
}
