using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.abort_
{

	public static class _OnDueX
	{
		/// <summary>
		/// </summary>
		/// <param name="_proc_unwaited"></param>
		/// <param name="cancelProcess">abort the process
		/// </param>
		/// <param name="lifeGiven"></param>
		/// <param name="extended4user2close"></param>
		/// <param name="waitAftKilling">only this time is not cancellable</param>
		/// <exception cref="TimeoutException">
		///		not end after wait
		/// </exception>
		/// <exception cref="Win32Exception">
		/// //The wait setting could not be accessed;
		/// </exception>
		public static void Vod(
			Process _proc_unwaited
			,
			int defer
			,
			int _user2close_positive
		)
		{

			using (
				var processWaited = new CancellationTokenSource()
				)
			{
				Task.Delay(defer, processWaited.Token)
				 .ContinueWith(
					  t => cull_._CancellableX.Exited0cancelledAsyn(
							  _proc_unwaited
							  , _user2close_positive
							  , processWaited.Token
						   )
					  ,
					  TaskContinuationOptions.NotOnCanceled
				 );

				 _proc_unwaited.WaitForExit(
					
				); 
				processWaited.Cancel();
	

			}
		}



		public static void Vod(
			Process _proc_unwaited
			,
			int? defer
			,
			int? minimum4user2close = null
		)
		{

			///we will wait for the proces later; as killing is asyn, we need the wait;
			///

			Vod(
				_proc_unwaited
				,
				os.Properties.SettingsX._Life4proc(defer)

				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
			);
		}

	
	}
}
