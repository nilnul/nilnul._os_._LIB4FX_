using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.abort_.throwKilling_.onCancel_
{
	/// <summary>
	///  end a cancelable process;
	/// </summary>
	public static class _ByUseCancelAsPulseX
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
			int _user2close_positive
			,
			int _waitAftKilling_positive
		)
		{

			 var processWaited = new CancellationTokenSource();

			var registered = cancel.Register(
				() => close_.defer_._CancellableX.Exited0cancelledAsyn(_proc_unwaited, _user2close_positive, processWaited.Token)
			);

			bool exited = false;
			var usr9sysTime = _user2close_positive + _waitAftKilling_positive;
			while (!exited)
			{
				if (cancel.IsCancellationRequested)
				{
					exited = _proc_unwaited.WaitForExit((_waitAftKilling_positive));
					break;

				}
				exited = _proc_unwaited.WaitForExit(usr9sysTime); //may be 
			}
			registered.Dispose();  //not on cancel any more
			processWaited.Cancel(); //not run any more
			processWaited.Dispose();

			if (!exited)
			{
				_KillX.UnexitedAsXpn(_proc_unwaited);
			}





		}

		public static void Vod(
			Process _proc_unwaited
			,
			CancellationToken canel
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
				canel
				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
				,
				os.Properties.SettingsX._WaitAftKilling(waitAftKilling));
		}
	}
}
