using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace nilnul.os.proc
{

	/*


The main window is the window opened by the process that currently has the focus (the TopLevel form). You must use the Refresh method to refresh the Process object to get the current main window handle if it has changed.

You can get the MainWindowHandle property only for processes that are running on the local computer. The MainWindowHandle property is a value that uniquely identifies the window that is associated with the process.

A process has a main window associated with it only if the process has a graphical interface. If the associated process does not have a main window, the MainWindowHandle value is zero. The value is also zero for processes that have been hidden, that is, processes that are not visible in the taskbar. This can be the case for processes that appear as icons in the notification area, at the far right of the taskbar.

If you have just started a process and want to use its main window handle, consider using the WaitForInputIdle method to allow the process to finish starting, ensuring that the main window handle has been created. Otherwise, an exception will be thrown.
	 */

	/*
	 MainWindowHandle isn't reliable for what you're trying to do.  It's mainly just designed for getting access to a process'es handle so you can send it a message (such as close).  Taking a quick look at the impl it relies on EnumWindows which won't pull hidden windows.  Hence you won't get any value if the window is hidden.  You can verify this by opening Notepad, running your app so you can see the handle, hiding Notepad (however you are doing that) and then call Refresh on the Notepad process instance.  You'll find the handle is now gone. 

I believe the FindWindow Win32 function can find hidden windows.  If you want to accomplish what you're trying to do then you're probably going to have to use it to find all windows.  For each window you'll have to get its process via GetWindowThreadProcessId.  Given the process ID you can get back to the .NET process.  This will be slow but it should work.
	 
	 */
	/*
	 The previous window handle is irrelevant.  There is no guarantees that when you "hide" a window that the visibility is just toggled.  There are many apps where hiding a window destroys it so when the window is shown again you get a new handle.  AFAIK there is no way to know whether a window was previously hidden because there is no persistent state available.  Even more complicated is the fact that initially a window may be hidden.  In this case the handle hasn't even been created yet.  A window handle doesn't get created until the window is getting ready to be displayed.  So given an arbitrary process determining all hidden windows is pretty much undoable.

What you can do is enumerate the top level windows (or the windows of a process) and determine their current visibility state.  But hidden windows may or may not be in that list (depends upon whether they are destroyed when hidden).  There is no way to know for sure unless you have complete control over the processes.
	 */

	/*
	 * social.msdn.microsoft.com/Forums/vstudio/en-US/71ea366e-6f65-485a-9caf-f0ce6bd2bd0e/how-to-determine-if-process-window-was-previously-hidden-and-list-hidden-windows?forum=csharpgeneral
	 * If:

You assume the window is only ever hidden and not destroyed
The main window is the only window you care about (even if there are several top level windows)
The main window is initially shown and then hidden (vs. initially hidden)
No splashscreens are involved
then the MainWindowHandle gives you the handle to the main window.  When that handle goes away the process is probably going to go away.  What the MainWindowHandle returns is the first window that was created in the process.  Windows assumes that this is the main window but often that is not the case anymore.  For example most apps display a splash screen which would normally be the first window.  In the case of WinForms (where the same assumption is made) apps often have to create the main window and then hide it before showing the splash screen.  It is frustratingly difficult.

An alternative approach may be to query the top level windows and then match them back to the owning process.  Certainly slower but it would get all top level windows of a process irrelevant of creation order.  Additionally if you wanted all the top windows of a process this is the only solution.

Michael Taylor - 5/11/2012
http://msmvps.com/blogs/p3net*/
	/// <summary>
	/// zero if win is hidden
	/// </summary>
	/// 

	public static class _MainWinX
	{

		public static IntPtr InTime(Process proc, int? miliseconds = null)
		{

			if (proc.HasExited)
			{
				return IntPtr.Zero;
			}

			try
			{
				if (proc.MainWindowHandle != IntPtr.Zero)  // don't refresh this if MainwindowHandle is not zero. when the main window may is hidden, this property will be refreshed as zero as if window is detached.
				{
					return proc.MainWindowHandle;
				}

				try
				{
					proc.WaitForInputIdle(miliseconds ?? nilnul.os.Properties.Settings.Default.procWait4Handle);
				}
				catch (Exception)
				{
					//proc.WaitForInputIdle(
					//	wait4input
					//);
					/*C:\Program Files\Git\bin\git.exe commit --allow-empty  -m"add and commit all for backup"
					   D:\r\
	:::
	System.InvalidOperationException: WaitForInputIdle 失败。  这可能是因为该进程没有图形界面。
	   在 System.Diagnostics.Process.WaitForInputIdle(Int32 milliseconds)
	   在 nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui.act_.bottom_.inact1min_._TitleX.Act(Process& proc, String title, Int32 wait4input) 位置:行号 21*/
					//throw;
				}

				var b=SpinWait.SpinUntil(
					delegate
					{

						proc.Refresh();
						return proc.MainWindowHandle != IntPtr.Zero;
					}
					,
					miliseconds ?? nilnul.os.Properties.Settings.Default.procWait4Handle //five minutes
				);

				return proc.MainWindowHandle;

			}
			catch (
				InvalidOperationException e//The MainWindowHandle is not defined because the process has exited.
			)
			{
				//Trace.TraceError($"{typeof(_MainWinX)}.{nameof(RefreshInTime)}( {proc} ,{miliseconds} on {proc}):{e} (The MainWindowHandle is not defined because the process has exited) ");
				return IntPtr.Zero;
			}
			catch (Exception ex)
			{
				Trace.TraceError($"{typeof(_MainWinX)}.{nameof(InTime)}( {proc} ,{miliseconds} on {proc}):{ex} () ");
				return IntPtr.Zero;

			}

		}

	}
}
