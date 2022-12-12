using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.uis
{
	static public class _FindX
	{
		[DllImport("User32.dll")]
		private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string strClassName, string strWindowName);

		[DllImport("user32.dll")]
		private static extern int GetWindowThreadProcessId(IntPtr hWnd, out int ProcessId);


		static public IntPtr OfProcId( int procId) //Unhide Process
		{
			IntPtr handle = IntPtr.Zero;
			int prcsId = 0;

			//check all open windows (not only the process we are looking) begining from the
			//child of the desktop, handle = IntPtr.Zero initialy.
			do
			{
				//get child handle of window who's handle is "handle".
				handle = FindWindowEx(IntPtr.Zero, handle, null, null);

				GetWindowThreadProcessId(handle, out prcsId); //get ProcessId from "handle"

				//if it matches what we are looking
				if (prcsId == procId)
				{
					return handle;
					//ShowWindow(handle, SW_RESTORE); //Show Window

					//return;
				}
			} while (handle != IntPtr.Zero);
			return handle;
		}
		static public IntPtr OfProcId_onYield( int procId) //Unhide Process
		{
			return Handles_ofProcId(procId).FirstOrDefault();
		}
		static public IEnumerable< IntPtr> Handles_ofProcId( int procId) //Unhide Process
		{
			IntPtr handle = IntPtr.Zero;
			int prcsId = 0;

			//check all open windows (not only the process we are looking) begining from the
			//child of the desktop, handle = IntPtr.Zero initialy.
			do
			{
				//get child handle of window who's handle is "handle".
				handle = FindWindowEx(IntPtr.Zero, handle, null, null);

				GetWindowThreadProcessId(handle, out prcsId); //get ProcessId from "handle"

				//if it matches what we are looking
				if (prcsId == procId)
				{
					yield return handle;
					//ShowWindow(handle, SW_RESTORE); //Show Window

					//return;
				}
			} while (handle != IntPtr.Zero);
			//return handle;
		}

		static public IntPtr Handle( Process procId) //Unhide Process
		{
			return OfProcId( procId.Id );
		}
		static public IEnumerable< IntPtr> Handles( Process procId) //Unhide Process
		{
			return Handles_ofProcId( procId.Id );
		}



	}
}
