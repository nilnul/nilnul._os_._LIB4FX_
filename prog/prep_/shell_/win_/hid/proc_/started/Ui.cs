using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started
{
	static public class _UiX
	{

		public delegate bool EnumThreadDelegate(IntPtr hWnd, IntPtr lParam);

		[DllImport("user32.dll")]
		public static extern bool EnumThreadWindows(int dwThreadId, EnumThreadDelegate lpfn,
			IntPtr lParam);


		public static List<IntPtr> ThreadWinEs(int processId)
		{
			var handles = new List<IntPtr>();

			foreach (ProcessThread thread in Process.GetProcessById(processId).Threads)
			{
				EnumThreadWindows(thread.Id,
									(hWnd, lParam) => { handles.Add(hWnd); return true; }
									, IntPtr.Zero
				);
			}


			return handles;
		}
		public static IntPtr ThreadWinFirst0default(int processId)
		{
			return ThreadWinEs(processId).FirstOrDefault();
		}

		public static List<IntPtr> ThreadWinEs(Process process)
		{
			return ThreadWinEs( process.Id);
		}

		public static IntPtr ThreadWinFirst0default(Process proc)
		{
			return ThreadWinFirst0default( proc.Id);
		}
	}
}
