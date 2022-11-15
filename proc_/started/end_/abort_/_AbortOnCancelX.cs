using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.end_
{
	/// <summary>
	///  end a cancelable process;
	/// </summary>
	public static class _AbortOnCancelX
	{
		/// <summary>
		/// </summary>
		/// <param name="_proc_unwaited"></param>
		/// <param name="cancelProcess">
		/// abort the process
		/// </param>
		/// <param name="lifeGiven"></param>
		/// <param name="extended4user2close"></param>
		/// <param name="waitAftKilling">o
		/// </param>
		public static void Vod(
			Process _proc_unwaited
			,
			CancellationToken cancel
			,
			int _user2close_positive
			,
			int _waitAftKilling_positive
		)
		{

			///we will wait for the proces later; as killing is asyn, we need the wait;
			///
			var processWaited = new CancellationTokenSource();

			var killed = false;


			cancel.Register(
				() => started_.unwaited.close._KillingX.EndedAsyn(_proc_unwaited, processWaited.Token, _user2close_positive).ContinueWith(
					t => killed = true
				)
			);



			bool waited = false;

			try
			{
				var lifeExpected = _user2close_positive + _waitAftKilling_positive;
				while (!waited)
				{
					if (killed)
					{
						waited = _proc_unwaited.WaitForExit(( _waitAftKilling_positive)); 
						break;

					}
					else
					{
						waited = _proc_unwaited.WaitForExit(lifeExpected); //may be 
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

			if (waited)
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
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
				,
				os.Properties.SettingsX._WaitAftKilling(waitAftKilling));
		}
	}
}
