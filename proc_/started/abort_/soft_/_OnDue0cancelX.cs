using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.quit_.abort_.soft_
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
			int remainedLife
			,
			CancellationToken cancelProcess
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

				var linkedToken4cancel = CancellationTokenSource.CreateLinkedTokenSource(cancelProcess, procWaitedToken);

				var killing = false;

				/*
				 cancle or timeout;
				to kill
				 */
				Task.Delay(remainedLife, linkedToken4cancel.Token)
				.ContinueWith(
					t =>
					{
						if (procWaitedToken.IsCancellationRequested)
						{
							return;
						}

						var closed = _abort._kill._CloseX.Ended(
							_proc_unwaited, processWaited.Token, _user2close_positive
						 );  //
						if (closed)
						{
							return;
						}
						if (procWaitedToken.IsCancellationRequested)
						{
							return;
						}
						killing = true;

						_proc_unwaited.Kill();
					}
				);

				bool exited = false;
				while (!exited)
				{
					if (killing)
					{
						break;
					}
					else
					{
						//exited = _proc_unwaited.WaitForExit(_waitAftKilling_positive);
						exited = _proc_unwaited.WaitForExit(remainedLife);
					}
				}
				if (killing)
				{
					throw new abort_.xpn_.KillingException(
						$"{_proc.prep.phrase_._DirCmdArgX.Phrase(_proc_unwaited.StartInfo)} is being killed; {nameof(remainedLife)}:{remainedLife};user2cancel: {cancelProcess.IsCancellationRequested}; {nameof(_user2close_positive)}:{_user2close_positive}; waitAftKilling:{_waitAftKilling_positive};"
						
					);
				}
				processWaited.Cancel();

			}
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
