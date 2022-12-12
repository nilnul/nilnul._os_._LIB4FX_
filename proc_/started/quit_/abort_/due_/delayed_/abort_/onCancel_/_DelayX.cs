using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started_.doodle.quit_.abort_.onCancle_
{
	/// <summary>
	///  cancel or timeout or exitEvt, which comes first
	///  
	/// </summary>
	public static class _DelayX
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
		public static async void Vod(
			Process _proc_unwaited
			,
			int life
			,
			CancellationToken cancel
			,
			int extended
			,
			int _user2close_positive
			,
			int _waitAftKilling_positive
		)
		{
			//_proc_unwaited.EnableRaisingEvents = true;
			bool exited = false;


			using (var processWaited = new CancellationTokenSource())
			{
				var procWaitedToken = processWaited.Token;

				var t = CancellationTokenSource.CreateLinkedTokenSource(cancel, procWaitedToken);


				var killed = false;

				/*
				 cancle or timeout;
				to kill

				 */
				Task.Delay(life, t.Token).ContinueWith(
					t => Task.Delay(
						extended
						,
						procWaitedToken
					)
				).ContinueWith(
					t => started.quit_._abort. _KillingX.EndedAsyn(_proc_unwaited, procWaitedToken, _user2close_positive)
				).ContinueWith(t => killed = true);

				var extendedTotal = extended + _user2close_positive + _waitAftKilling_positive;
				var totalIncExtend = life + extendedTotal;

				while (!exited)
				{
					if (killed)
					{
						exited = _proc_unwaited.WaitForExit(_waitAftKilling_positive);
						break;

					}
					else
					{
						if (cancel.IsCancellationRequested)
						{
							exited = _proc_unwaited.WaitForExit(extendedTotal);

						}
						else
						{
							exited = _proc_unwaited.WaitForExit(totalIncExtend);

						}
					}
				}

				processWaited.Cancel();

			}

			if (exited)
			{
				return;
			}

			throw new proc_.started_.waited_.xpn_.TimeoutException(
				$"{_proc.prep.phrase_._DirCmdArgX.Phrase(_proc_unwaited.StartInfo)} had been killed; and we waited for {_waitAftKilling_positive} and it still doesnot end; maybe it's not responding, say due to Os halt cuz of little resources?"
			);
		}

		public static void Vod(
			Process _proc_unwaited
						,
			CancellationToken cancel
			,
			int? life

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
				os.Properties.SettingsX._Life4proc(life)

				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
				,
				os.Properties.SettingsX._WaitAftKilling(waitAftKilling));
		}
	}
}
