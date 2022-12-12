using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.quit_.abort_
{

	/// <summary>
	/// <see cref="_abort.kill_._KillingAsXpnX"/>
	/// </summary>
	public interface IForce { }


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
	public static class _KillingAsXpnX
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
		)
		{
	

					  var closed = _abort._kill._CloseX.Ended(
						  _proc_unwaited, processWaited.Token, _user2close_positive
					   );  //
					  if (closed)
					  {
						  return;
					  }
					  if (processWaited.IsCancellationRequested)
					  {
						  return;
					  }
					  /// we prefer false killed, rather than false grace bowout;
					  _proc_unwaited.Kill();


				  }
				,
					TaskContinuationOptions.NotOnCanceled
			 );




			//var killingTime = _user2close_positive + _waitAftKilling_positive;

			//var lifeAndKilling = defer + killingTime;
			bool exited = false;

			while (!exited)
			{
				if (killing) // ; when kill is done, we will not wait in case a process doesnot respond. also 
				{
					break;
				}
				else
				{
					/// <see cref="waitTime"/> has to be short, as we cannot cancel this early;
					exited = _proc_unwaited.WaitForExit(defer); //may be proc is already killed
				}
			}//if the process run its own course and complete, we need to cancel;
			processWaited.Cancel();

			if (killing)
			{
				throw new abort_.xpn_.KillingException();
			}





		}

		//processWaited.Dispose();





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

