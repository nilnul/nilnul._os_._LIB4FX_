using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace nilnul.os.ui.show_
{


	/// <summary>
	/// </summary>
	public static class _NormalX
	{

		public static void _inNonNil(IntPtr _hWnd)
		{

			_ShowWindowX.ShowWindow(_hWnd, _show.Command_.Normal); 
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
