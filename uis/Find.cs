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


		/// <summary>
		/// 
		/// </summary>
		/// <param name="procId"></param>
		/// <returns></returns>
		/// <exception cref="">
		///		/// System.ObjectDisposedException: 已关闭 Safe handle
		////在 System.Runtime.InteropServices.SafeHandle.DangerousAddRef(Boolean& success)
		//// 在 System.StubHelpers.StubHelpers.SafeHandleAddRef(SafeHandle pHandle, Boolean& success)
		//// 在 Microsoft.Win32.NativeMethods.NtQueryInformationProcess(SafeProcessHandle processHandle, Int32 query, NtProcessBasicInfo info, Int32 size, Int32[] returnedSize)
		//// 在 System.Diagnostics.NtProcessManager.GetProcessIdFromHandle(SafeProcessHandle processHandle)
		//// 在 System.Diagnostics.ProcessManager.GetProcessIdFromHandle(SafeProcessHandle processHandle)
		//// 在 System.Diagnostics.Process.EnsureState(State state)
		//// 在 System.Diagnostics.Process.get_Id()
		/// </exception>
		static public IntPtr OfProcId(int procId) //Unhide Process
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
		static public IntPtr OfProcId_onYield(int procId) //Unhide Process
		{
			return Handles_ofProcId(procId).FirstOrDefault();
		}
		static public IEnumerable<IntPtr> Handles_ofProcId(int procId) //Unhide Process
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

		static public IntPtr Handle(Process procId) //Unhide Process
		{

			return OfProcId(
				procId.Id /*System.ObjectDisposedException: 已关闭 Safe handle
   在 System.Runtime.InteropServices.SafeHandle.DangerousAddRef(Boolean& success)
   在 System.StubHelpers.StubHelpers.SafeHandleAddRef(SafeHandle pHandle, Boolean& success)
   在 Microsoft.Win32.NativeMethods.NtQueryInformationProcess(SafeProcessHandle processHandle, Int32 query, NtProcessBasicInfo info, Int32 size, Int32[] returnedSize)
   在 System.Diagnostics.NtProcessManager.GetProcessIdFromHandle(SafeProcessHandle processHandle)
   在 System.Diagnostics.ProcessManager.GetProcessIdFromHandle(SafeProcessHandle processHandle)
   在 System.Diagnostics.Process.EnsureState(State state)
   在 System.Diagnostics.Process.get_Id()*/

			);
		}
		static public IEnumerable<IntPtr> Handles(Process procId) //Unhide Process
		{
			return Handles_ofProcId(procId.Id);
		}



	}
}
