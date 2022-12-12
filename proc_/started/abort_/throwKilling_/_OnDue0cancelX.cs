using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.abort_.throwKilling_
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

			using var processWaited = new CancellationTokenSource();

			var procWaitedToken = processWaited.Token;

			using var linkedToken4cancel = CancellationTokenSource.CreateLinkedTokenSource(cancelProcess, procWaitedToken);

			Task.Delay(remainedLife, linkedToken4cancel.Token)
			.ContinueWith(
				t =>
				{
					if (procWaitedToken.IsCancellationRequested)
					{
						return;
					}
					close_.defer_._CancellableX.Exited0cancelledAsyn(
					   _proc_unwaited, _user2close_positive, procWaitedToken
					);  //
				}
			);

			var exited = _proc_unwaited.WaitForExit(remainedLife + _user2close_positive + _waitAftKilling_positive);
			processWaited.Cancel();
			//linkedToken4cancel.Dispose();
			if (!exited)
			{
				_KillX.UnexitedAsXpn(_proc_unwaited);
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
