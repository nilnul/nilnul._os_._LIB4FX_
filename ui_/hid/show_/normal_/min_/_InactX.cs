using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace nilnul.os.ui.act_.show_.min_
{


	/// <summary>
	/// </summary>
	public static class _InactX
	{

		public static void _inNonNil(IntPtr _hWnd)
		{

			_ShowWindowX.ShowWindow(_hWnd, _show.Command_.ShowMinNoActive); 
		}

		public static void Act(IntPtr hWnd)
		{
			if (hWnd != IntPtr.Zero)
			{
				_inNonNil(hWnd); 
			}
		}



	}
}
