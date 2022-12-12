using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace nilnul.os.ui.show_
{
	/// <summary>
	/// by set the current process background
	/// </summary>
	public static class _HideX
	{
		public static void _Hide_ofNonNil(IntPtr _hWnd)
		{
			
				_ShowWindowX.ShowWindow(_hWnd, (int) _show.Command_.Hide); // 0 = SW_HIDE
		}

		public static void Hide(IntPtr hWnd)
		{
			if (hWnd != IntPtr.Zero)
			{
				_Hide_ofNonNil(hWnd);
			}
		}



		public static void Hide(Process proc)
		{
			if (!proc.HasExited)
			{
				IntPtr handler;
				try
				{
					handler = proc.MainWindowHandle;
				}
				catch (InvalidOperationException e)
				{

					return;
				}
				Hide(handler);

			}
		}


		public static void HideInTime(Process proc, int? miliseconds= null)
		{
			var i=os.proc_.started.ui_._MainX.Attempted(proc, miliseconds);
			Hide(i);
		}


	}
}
