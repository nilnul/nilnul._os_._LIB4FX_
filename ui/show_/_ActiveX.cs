using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace nilnul.os.ui.show_
{


	/// <summary>
	/// </summary>
	public static class _ActiveX
	{

		public static void _assumeNonnil(IntPtr _hWnd)
		{

			_ShowWindowX.ShowWindow(_hWnd, _show.Command_.Show); 
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
