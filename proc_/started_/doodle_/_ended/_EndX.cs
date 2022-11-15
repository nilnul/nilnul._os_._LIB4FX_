using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.deadlined
{
	/// <summary>
	/// two threads:
	///		1) the process discourses itself;
	///		2) a killer; when cancelling, we will terminate the process (allowing some time for it to clean up;);
	///	coordinate:
	///		1) if the process ends early, killer will ignore the cancelling;
	///		2) when the user knows that the process has been ended, he will not call killer; he will call killer only when he is not sure whether the process has been ended; the killer will end the process;
	/// </summary>
	/// alias:
	///		retire
	///			after some years
	///		defer
	///		delay
	///		due
	///		waitOut,
	///			analog to timeout
	public static class _EndX
	{
		/// <summary>
		/// </summary>
		/// <param name="_proc_unwaited"></param>
		/// <param name="cancelProcess">abort the process
		/// </param>
		/// <param name="lifeGiven"></param>
		/// <param name="extended4user2close"></param>
		/// <param name="waitAftKilling">only this time is not cancellable</param>
		/// <exception cref="TimeoutException">
		///		not end after wait
		/// </exception>
		/// <exception cref="Win32Exception">
		/// //The wait setting could not be accessed;
		/// </exception>
		public static void Vod(
			Process _proc_unwaited
			,
			int defer
			,
			int _user2close_positive
			,
			int _waitAftKilling_positive
		)
		{
			var killDone = false;
			///we will wait for the proces later; as killing is asyn, we need the wait;
			///
			var processWaited = new CancellationTokenSource();

			_end._KillX._EndedAsyn(
				_proc_unwaited
				,
				processWaited
				.
				Token, defer
				,
				_user2close_positive
			).ContinueWith(
				t => killDone = true
			);

			bool exited = false;

			var killingTime = _user2close_positive + _waitAftKilling_positive;

			var lifeAndKilling =  defer+killingTime;
			try
			{
				while (!exited)
				{
					if (killDone)
					{
						/// <see cref="waitTime"/> has to be short, as we cannot cancel this early;
						exited = _proc_unwaited.WaitForExit(killingTime); //may be proc is already killed
						break;

					}
					else
					{
						/// <see cref="waitTime"/> has to be short, as we cannot cancel this early;
						exited = _proc_unwaited.WaitForExit(defer); //may be proc is already killed
						
					}


				}
			}
			catch (Win32Exception)//The wait setting could not be accessed.
			{
				throw;
			}
			catch (Exception x) /*
SystemException
No process Id has been set, and a Handle from which the Id property can be determined does not exist.

-or -

There is no process associated with this Process object.

- or -

You are attempting to call WaitForExit() for a process that is running on a remote computer.This method is available only for processes that are running on the local computer.)
						                   
						                   */
			{
				Trace.TraceError(
					@$"{os._proc._trace._CallSiteX.TxtOfCallSite()}

::::::::::

{x}"
				);
				return;
			}
			finally
			{
				processWaited.Cancel();
				processWaited.Dispose();
			}

			if (exited)
			{
				return;
			}

			throw new proc_.started_.waited_.xpn_.TimeoutException(
				$"{_proc.prep.phrase_._DirCmdArgX.Phrase(_proc_unwaited.StartInfo)} had been killed; and we waited for {_waitAftKilling_positive} and it still doesnot end; maybe it's not responding?"
			);
		}

		public static void Vod(
			Process _proc_unwaited
			,
			int? defer
			,
			int? minimum4user2close = null
			,
			int? waitAftKilling = null
		)
		{

			///we will wait for the proces later; as killing is asyn, we need the wait;
			///

			Vod(
				_proc_unwaited
				,
				os.Properties.SettingsX._Life4proc(defer)

				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
				,
				os.Properties.SettingsX._WaitAftKilling(waitAftKilling));
		}
	}
}
