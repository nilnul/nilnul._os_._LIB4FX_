using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.abort_.throwQuitTimeout_
{
	/// <summary>
	///  cancel or timeout or exitEvt, which comes first
	///  
	/// </summary>
	/// alias:
	///		onDue0cancel
	///			such that par:life comes before cancel
	///				in align with <see cref="abort_.delayed_._OnDue0cancelX"/>
	public static class _OnDue0cancelX
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

				var t = CancellationTokenSource.CreateLinkedTokenSource(cancel,procWaitedToken);


				var killed = false;

				/*
				 cancle or timeout;
				to kill

				 */
				Task.Delay(life, t.Token).ContinueWith(
					t => {
						if (procWaitedToken.IsCancellationRequested)
						{
							return;
						}
						started.cull_._CancellableX.Exited0cancelledAsyn(
							_proc_unwaited
							, _user2close_positive
							, procWaitedToken
						);
					}

				).ContinueWith(t => killed = true);


				while (!exited)
				{
					if (killed)
					{
						exited = _proc_unwaited.WaitForExit(_waitAftKilling_positive);
						break;

					}
					else
					{
						//exited = _proc_unwaited.WaitForExit(_waitAftKilling_positive);
						exited = _proc_unwaited.WaitForExit( life); 
					}
				}

				processWaited.Cancel();

			}

			if (exited)
			{
				return;
			}

			throw new proc_.started.quit_.xpn_.Timeout(
				$"{_proc.prep.phrase_._DirCmdArgX.Phrase(_proc_unwaited.StartInfo)} had been killed; and we waited for {_waitAftKilling_positive} and it still doesnot end; maybe it's not responding, say due to Os halt cuz of little resources?"
			);
		}

		public static void Vod(
			Process _proc_unwaited
			,
			int? life
						,
			CancellationToken cancel

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
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
				,
				os.Properties.SettingsX._WaitAftKilling(waitAftKilling));
		}
	}
}
