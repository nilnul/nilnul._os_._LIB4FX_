using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System;
using System.Diagnostics;
using System.Threading;

namespace nilnul.os.ui.position_
{
	public class _BottomX
	{
		public static void ShoveToBackground(int handle)
		{
			_PositionX.SetWindowPos(handle, 1, 0, 0, 0, 0, 19u);
		}

		public static void ShoveToBackground_assumeNotNil(IntPtr mainWindowHandle)
		{
			ShoveToBackground((int)mainWindowHandle);
		}

		public static void InTime(Process proc, int miliseconds = 300000)
		{
			var handle = os.proc_.started.ui_._MainX.Attempted(proc, miliseconds);

			OfHandle(handle);
		}

		public static void IfWin(Process proc)
		{
			if (proc.MainWindowHandle != IntPtr.Zero)
			{
				ShoveToBackground_assumeNotNil(proc.MainWindowHandle);
			}
		}

		public static void OfHandle(IntPtr proc)
		{
			if (proc != IntPtr.Zero)
			{
				ShoveToBackground_assumeNotNil(proc);
			}
		}

		public static void _OvHandleNotNil(Process proc)
		{
			ShoveToBackground_assumeNotNil(proc.MainWindowHandle);
		}
	}
}
