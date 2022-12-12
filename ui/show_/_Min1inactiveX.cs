using nilnul.os.ui._show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.ui.show_
{
	public static class _Min1inactiveX
	{
		public static void _Vod_assumeNonnil(IntPtr _hWnd)
		{
			_ShowWindowX.ShowWindow(
				_hWnd
				,
				Command_.ShowMinNoActive
			);
		}

		[Obsolete(nameof(_Vod_assumeNonnil))]
		public static void _assumeNonnil(IntPtr _hWnd)
		{
			_Vod_assumeNonnil(_hWnd);
		}


		public static void Act(IntPtr hWnd)
		{
			if (hWnd != IntPtr.Zero)
			{
				_Vod_assumeNonnil(hWnd);
			}
		}
	}
}
