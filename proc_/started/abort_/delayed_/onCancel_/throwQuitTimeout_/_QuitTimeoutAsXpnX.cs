using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.abort_.delayed_.onCancel_.quitTimeoutAsXpn_
{
	/// <summary>
	///  end a cancelable process;
	/// </summary>
	public static class _QuitTimeoutAsXpnX
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
			int runAftCancel
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
				() => Task.Delay(runAftCancel, processWaited.Token).ContinueWith(
					t => cull_._CancellableX.Exited0cancelledAsyn(
						_proc_unwaited,
						processWaited.Token
						,
						_user2close_positive
					)
					, TaskContinuationOptions.NotOnCanceled
				).ContinueWith(
					t => killed = true
				)
			);

			bool exited = false;

			var lifeExpected = runAftCancel + _user2close_positive + _waitAftKilling_positive;
			while (!exited)
			{
				if (killed)
				{
					exited = _proc_unwaited.WaitForExit((_waitAftKilling_positive));
					break;

				}
				else
				{
					exited = _proc_unwaited.WaitForExit(lifeExpected); //may be 
				}
			}

			processWaited.Cancel();
			processWaited.Dispose();


			if (exited)
			{
				return;
			}

			throw new proc_.started.quit_.xpn_.Timeout(
				$"{_proc.prep.phrase_._DirCmdArgX.Phrase(_proc_unwaited.StartInfo)} had been killed; and we waited for {_waitAftKilling_positive} and it still doesnot end; maybe it's not responding?"
			);
		}

		public static void Vod(
			Process _proc_unwaited
			,
			CancellationToken cancel
			,
			int? runAftCancel = null
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
				cancel

				,
				os.Properties.SettingsX._RunAftCancel(runAftCancel)

				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
				,
				os.Properties.SettingsX._WaitAftKilling(waitAftKilling));
		}
	}
}
