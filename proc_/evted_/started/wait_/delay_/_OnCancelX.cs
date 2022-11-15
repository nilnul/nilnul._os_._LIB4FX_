using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.evted_.started.wait__
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
		public static Task<bool> Task(
			Process _proc_evtedUnhooked
			,
			CancellationToken cancel
			,
			int life
		)
		{
			var tcs = new TaskCompletionSource<bool>(false);

			var processExited = CancellationTokenSource.CreateLinkedTokenSource(cancel);


			_proc_evtedUnhooked.Exited += (sender, args) =>
			{
				processExited.Cancel();
				tcs.TrySetResult(true);
				
			};

			_proc_evtedUnhooked.Start();

			System.Threading.Tasks.Task.Delay(
				life
				,
				
				processExited.Token
			).ContinueWith(

				t => tcs.TrySetCanceled() //even it's cancelled, it might later exit success;
				,
				processExited.Token
			);

			return tcs.Task;
		
		}

	

		public static void Vod(
			Process _proc_unwaited
						,
			CancellationToken cancel
			,
			int? life

		)
		{

			///we will wait for the proces later; as killing is asyn, we need the wait;
			///

			Task(
				_proc_unwaited
				,
				cancel
				,
				os.Properties.SettingsX._Life4proc(life)
			);
		}
	}
}
