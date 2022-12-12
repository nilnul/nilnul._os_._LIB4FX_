using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.abort_.delayed_.onCancel_
{
	/// <summary>
	///  end a cancelable process;
	/// </summary>
	public static class _ThrowKillingX
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
		)
		{

			///we will wait for the proces later; as killing is asyn, we need the wait;
			///

			using var processWaited = new CancellationTokenSource();

			cancel.Register(
				() => Task.Delay(runAftCancel, processWaited.Token).ContinueWith(
					t => close_.defer_._CancellableX.Exited0cancelledAsyn(
						_proc_unwaited
						,
						_user2close_positive
						,
						processWaited.Token
					)
					,
					TaskContinuationOptions.NotOnCanceled
				)
			);

			var extendedTotal4Close = runAftCancel + _user2close_positive ;

			var exited = false;

			while (!exited)
			{
				if (cancel.IsCancellationRequested)
				{
					exited = _proc_unwaited.WaitForExit(extendedTotal4Close);

					break;
				}
				else
				{
					exited = _proc_unwaited.WaitForExit(extendedTotal4Close);
				}
			}

			processWaited.Cancel();

			if (exited)
			{
				return;
			}
			_KillX.UnexitedAsXpn(_proc_unwaited);

		}

		public static void Vod(
			Process _proc_unwaited
			,
			CancellationToken cancel
			,
			int? runAftCancel = null
			,
			int? minimum4user2close = null
			//,
			//int? waitAftKilling = null
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
				//,
				//os.Properties.SettingsX._WaitAftKilling(waitAftKilling)
			);
		}
	}
}
