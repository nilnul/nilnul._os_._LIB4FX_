using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.evted_.started.quit_.abort_
{
	/// <summary>
	///  cancel or timeout or exitEvt, which comes first
	///  
	/// </summary>
	public static class _OnCancel0dueX
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
		public static void Vod(
			Process _proc_evtedUnhooked
			,
			CancellationToken cancel
			,
			int life
			,
			int _user2close_positive
		)
		{
			var processExitedSource = new CancellationTokenSource();
			var processExited = processExitedSource.Token;

			var linked = CancellationTokenSource.CreateLinkedTokenSource(cancel, processExited);


			void f(object sender, EventArgs args)
			{
				processExitedSource.Cancel();

			};

			_proc_evtedUnhooked.Exited += f;

			_proc_evtedUnhooked.Start();


			Task.Delay(
				life
				,
				linked.Token
			).ContinueWith(t =>
				 nilnul.os.proc_.started.cull_._CancellableX.Exited0cancelledAsyn(
						_proc_evtedUnhooked
						,
						_user2close_positive
						,
						processExited
				)
				,
				processExited
			 );

			return ;

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
			);
		}
	}
}
