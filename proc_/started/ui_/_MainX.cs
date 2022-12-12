using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;

namespace nilnul.os.proc_.started.ui_
{
	/// https://stackoverflow.com/questions/67058960/getting-hwnd-of-a-hidden-window
	/// <summary>
	/// 
	/// </summary>
	public static class _MainX
	{
		//public static bool SucceedInTime(Process proc, int? miliseconds = null)
		//{
		//	try
		//	{
		//		if (proc.HasExited)
		//		{
		//			return false;
		//		}

		//	}
		//	catch (Exception e)
		//	{
		//		nilnul.os.proc.act_._TraceAsErrX.TraceAsErr(ref proc, e);

		//		return false;
		//	}

		//	try
		//	{
		//		if (proc.MainWindowHandle != IntPtr.Zero)  // don't refresh this if MainwindowHandle is not zero. whenthe main window may is hidden, this property will be refreshed as zero as if window is detached.
		//		{
		//			return true;
		//		}

		//		return SpinWait.SpinUntil(
		//			delegate
		//			{

		//				proc.Refresh();
		//				return proc.MainWindowHandle != IntPtr.Zero;
		//			}
		//			,
		//			miliseconds ?? nilnul.os.Properties.Settings.Default.procWait4Handle //five minutes
		//		);



		//	}
		//	catch (
		//		InvalidOperationException e//The MainWindowHandle is not defined because the process has exited.
		//	)
		//	{
		//		//Trace.TraceError($"{typeof(_MainWinX)}.{nameof(RefreshInTime)}( {proc} ,{miliseconds} on {proc}):{e} (The MainWindowHandle is not defined because the process has exited) ");
		//		return false;
		//	}
		//	catch (Exception ex)
		//	{
		//		Trace.TraceError($"{typeof(_MainUiX)}.{nameof(SucceedInTime)}( {proc} ,{miliseconds} on {proc}):{ex} () ");
		//		return false;

		//	}

		//}
		public static IntPtr Attempted(Process proc, int miliseconds)
		{
			///for just started, no need to check isExited;
			try
			{
				if (proc.HasExited)
				{
					return default;
				}

			}
			//catch (InvalidOperationException ex) //no process
			//{
			//	return default;
			//}
			catch (Exception e)
			{
				nilnul.os.proc.act_._TraceAsErrX.TraceAsErr(ref proc, e);

			}
			IntPtr r = default;

			#region current no wait4input

			try
			{
				r = proc.MainWindowHandle;
				if (r != IntPtr.Zero)  // don't refresh this if MainwindowHandle is not zero. whenthe main window may is hidden, this property will be refreshed as zero as if window is detached.
				{
					return r;
				}
			}
			catch (
				InvalidOperationException e//The MainWindowHandle is not defined because the process has exited.
			)
			{
				//Trace.TraceError($"{typeof(_MainWinX)}.{nameof(RefreshInTime)}( {proc} ,{miliseconds} on {proc}):{e} (The MainWindowHandle is not defined because the process has exited) ");
				return default;
			}
			catch (Exception ex)
			{
				Trace.TraceError($"{typeof(_MainX)}.{nameof(Attempted)}( {proc} ,{miliseconds} on {proc}):{ex} () ");
				//return default;
				//os.proc.act_._TraceAsErrX.TraceAsErr(proc, ex);
			}

			var t = SpinWait.SpinUntil(
					delegate
					{
						proc.Refresh();
						try
						{

							return proc.MainWindowHandle != IntPtr.Zero;

						}
						catch (Exception)
						{

							return false;
						}
					}
					,
					miliseconds
				);

			if (t)
			{
				return proc.MainWindowHandle;

			}
			#endregion

			try
			{
				proc.WaitForInputIdle();
			}
			catch (Exception ex)
			{
				os.proc.act_._TraceAsErrX.TraceAsErr(proc, ex);
				//return default;
			}

			try
			{
				r = proc.MainWindowHandle;
				if (r!=default)
				{
					return r;
				}
			}
			catch (Exception)
			{

			}

			//refresh again;

			t = SpinWait.SpinUntil(
				delegate
				{
					proc.Refresh();
					try
					{

						return proc.MainWindowHandle != IntPtr.Zero;

					}
					catch (Exception)
					{

						return false;
					}
				}
				,
				miliseconds
			);

			if (t)
			{
				return proc.MainWindowHandle;

			}

			return r;





		}
		public static IntPtr Attempted(Process proc, int? miliseconds = null)
		{
			return Attempted(proc,

				miliseconds ?? nilnul.os.Properties.Settings.Default.procWait4Handle
			);
		}

		public static IntPtr Unrefreshed(Process proc)
		{

			try
			{
				return proc.MainWindowHandle;

			}
			catch (InvalidOperationException e) //hasExited
			{
				os.proc.act_._TraceAsErrX.TraceAsErr(ref proc, e);

				return default;

			}

		}

	}
}
