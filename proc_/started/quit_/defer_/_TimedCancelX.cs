using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.unwaited.due.close.kill.wait
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		waitOut,
	///			analog to timeout
	public static class _TimedCancelX
	{



		/// <summary>
		/// </summary>
		/// <param name="proc"></param>
		/// <param name="cancel">we can end the task early, when, say, we want to end the main application that spaws this process;</param>
		/// <param name="lifeGiven"></param>
		/// <param name="extended4user2close"></param>
		/// <param name="waitAftKilling">only this time is not cancellable</param>
		/// <exception cref="TimeoutException">
		///		not end after wait
		/// </exception>
		/// <exception cref="Win32Exception">
		/// //The wait setting could not be accessed;
		/// </exception>
		public static async Task Asyn(
			Process proc
			,
			CancellationToken cancel
			,
			int? lifeGiven = null
			,
			int? minimum4user2close = null
			,
			int? extended4user2close = null
			,
			int? waitAftKilling = null
		)
		{
			var waitAftKill_asInt = waitAftKilling ?? _due.Settings1.Default.waitAftKill;

			var totalTime = _CloseX._Due(
						lifeGiven
					)

					+
					waitAftKill_asInt;

			var cts= new CancellationTokenSource(
				totalTime
			);

	

			 await _WaitOutX.Asyn(proc, cts.Token, lifeGiven, minimum4user2close, extended4user2close);
	

	



		}
	}
}
