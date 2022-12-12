using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.abort_.delayed_.onDue0cancel_.quitTimeoutAsXpn_
{
	/// <summary>
	///  cancel or timeout or exitEvt, which comes first
	///  
	/// </summary>
	/// alias:
	///		onDue0cancel
	///			as the par:due appears first;
	///		onCancel0due
	///		
	public static class _BySepClose9killX
	{
		/// <summary>
		/// </summary>
		/// <param name="_proc_unwaited"></param>
		/// <param name="lifeCancelable">
		/// this time can be cut short by cancel;
		/// </param>
		/// <param name="cancelProcess">
		/// abort the process
		/// </param>
		/// <param name="runAftCancel">
		/// time cannot be cancelled manually, but can be cut short by processExit
		/// </param>
		/// <param name="extended4user2close"></param>
		/// <param name="waitAftKilling">o
		/// </param>
		public static async void Vod(
			Process _proc_unwaited
			,
			int lifeCancelable
			,
			CancellationToken userCancelProcess
			,
			int runAftCancel
			,
			int _user2close_positive
			,
			int _waitAftKilling_positive
		)
		{
			//_proc_unwaited.EnableRaisingEvents = true;


			using (var processWaited = new CancellationTokenSource())
			{
				var procWaitedToken = processWaited.Token;

				var linkedCancel = CancellationTokenSource.CreateLinkedTokenSource(userCancelProcess, procWaitedToken);


				var killed = false;

				/*
				 cancle or timeout;
				to kill

				 */
				Task.Delay(lifeCancelable, linkedCancel.Token).ContinueWith(
					t =>
					{
						if (processWaited.IsCancellationRequested) { return; }
						Task.Delay(
							runAftCancel
							,
							procWaitedToken //this cannot be cancelled by the user0callerCancelToken
						).ContinueWith(t =>
						{
							var closed = close_._DeferX.Exited0cancelled(
								_proc_unwaited, processWaited.Token, _user2close_positive
							 );
							if (closed) { return; }
							if (processWaited.IsCancellationRequested)
							{
								return;
							}
							_proc_unwaited.Kill();
							killed = true;

						}, TaskContinuationOptions.NotOnCanceled
						);
					}
				);

				var extendedTotal = runAftCancel + _user2close_positive + _waitAftKilling_positive;
				//var totalIncExtend = lifeCancelable + extendedTotal;

				bool exited = false;

				while (!exited)
				{
					if (killed)
					{
						exited = _proc_unwaited.WaitForExit(_waitAftKilling_positive);
						break;

					}
					else
					{
						if (userCancelProcess.IsCancellationRequested)
						{
							exited = _proc_unwaited.WaitForExit(extendedTotal);

						}
						else
						{
							exited = _proc_unwaited.WaitForExit(lifeCancelable);

						}
					}
				}
				processWaited.Cancel();
				if (exited)
				{
					return;
				}

				throw new proc_.started.wait_.exit_.xpn_.Timeout(
					$"{_proc.prep.phrase_._DirCmdArgX.Phrase(_proc_unwaited.StartInfo)} had been killed; and we waited for {_waitAftKilling_positive} and it still doesnot end; maybe it's not responding, say due to Os halt cuz of little resources?"
				);

			}

		}

		public static void Vod(
			Process _proc_unwaited
			, int? life
						,
			CancellationToken cancel

			,
			int? runAftCancel

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
				os.Properties.SettingsX._Life4proc(life)

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
