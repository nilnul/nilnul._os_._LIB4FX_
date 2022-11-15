using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.evted_.started.wait_
{
	/// <summary>
	///  cancel or timeout or exitEvt, which comes first
	///  
	/// </summary>
	public static class _AsTaskX
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
		)
		{
			var tcs = new TaskCompletionSource<bool>(false);

			_proc_evtedUnhooked.Exited += (sender, args) =>
			{
				tcs.TrySetResult(true);
				
			};

			_proc_evtedUnhooked.Start();

			_proc_evtedUnhooked.WaitForExit();
			//tcs.SetResult(true);

			return tcs.Task;
		
		}

	

	}
}
