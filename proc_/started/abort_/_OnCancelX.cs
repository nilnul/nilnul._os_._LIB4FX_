using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.abort_
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
		)
		{

			using (
				var processWaited = new CancellationTokenSource()
			)
			{
				cancel.Register(
					() => cull_._CancellableX.Exited0cancelledAsyn(_proc_unwaited, _user2close_positive, processWaited.Token)
					
				);
	
				 _proc_unwaited.WaitForExit(); 
				
				processWaited.Cancel();


			}




		}

		public static void Vod(
			Process _proc_unwaited
			,
			CancellationToken canel
			,
			int? minimum4user2close = null
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
			);
		}
	}
}
