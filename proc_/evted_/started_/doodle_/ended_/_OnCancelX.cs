using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started_.abortable_.doodle_
{
	/// <summary>
	///  cancel or timeout or exitEvt, which comes first
	///  
	/// </summary>
	public static class _OnCancelX
	{
		/// <summary>
		/// </summary>
		/// <param name="_proc_evtedStarted"></param>
		/// <param name="cancelProcess">
		/// abort the process
		/// </param>
		/// <param name="lifeGiven"></param>
		/// <param name="extended4user2close"></param>
		/// <param name="waitAftKilling">o
		/// </param>
		public static Task<bool> Vod(
			Process _proc_evtedUnhooked
			,
			CancellationToken cancel
			,
			int life
			,
			int _user2close_positive
		)
		{
			var tcs = new TaskCompletionSource<bool>(false);
			var processExited = new CancellationTokenSource();

			_proc_evtedUnhooked.Exited += (sender, args) =>
			{
				processExited.Cancel();
				tcs.TrySetResult(true);
				
			};


			_proc_evtedUnhooked.Start();

			Task.Delay(
				life
				,
				cancel
			).ContinueWith(

				t => nilnul.os.proc_.started_.unwaited.close._KillingX.EndedAsyn(
					_proc_evtedUnhooked
					,
					processExited.Token
					,
					_user2close_positive
				)
			);

			return tcs.Task;
		
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
