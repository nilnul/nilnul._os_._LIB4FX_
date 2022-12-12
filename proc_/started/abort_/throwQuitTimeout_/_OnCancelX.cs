using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.abort_.throwQuitTimeout_
{
	/// <summary>
	///  end a cancelable process;
	/// </summary>
	public static class _OnCancelX
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

			///we will wait for the proces later; as killing is asyn, we need the wait;
			///
			var processWaited = new CancellationTokenSource();

			bool exited0canlled = false;
			bool culled1 = false;

			var registered= cancel.Register(
				() => {
					Task.Run(
						()=>exited0canlled=	cull_._CancellableX.Exit0cancelled(
							_proc_unwaited
							,
							_user2close_positive
							,
							processWaited.Token
						)
					).ContinueWith(
						t => {
							exited0canlled = t.Result;
							culled1 = true;
						}
					);
				}
			);

			bool exited = false;

			var lifeExpected = _user2close_positive + _waitAftKilling_positive;
			while (!exited)
			{
				if (culled1)
				{
					if (exited0canlled)
					{
						return;
					}
					exited = _proc_unwaited.WaitForExit((_waitAftKilling_positive));
					break;
				}
				else
				{
					exited = _proc_unwaited.WaitForExit(lifeExpected); //may be 
				}
			}

			processWaited.Cancel();
			registered.Dispose();
			processWaited.Dispose();

			if (exited)
			{
				return;
			}

			throw new proc_.started.quit_.xpn_.Timeout(
				$"{_proc.prep.phrase_._DirCmdArgX.Phrase(_proc_unwaited.StartInfo)} had been killed; and we waited for {_waitAftKilling_positive} and it still doesnot end; maybe it's not responding?"
			);
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
