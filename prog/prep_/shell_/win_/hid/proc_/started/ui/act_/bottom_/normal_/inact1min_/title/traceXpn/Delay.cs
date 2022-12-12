using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui.act_.bottom_.normal_.inact1min_.title.traceXpn
{
	/// <summary>
	/// make this a task
	/// </summary>
	public static class _DelayX
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public static Task _AsTask_lurkAssumeNum(
			Process proc, string? title , CancellationToken cancel , int procLaterPop 
		)
		{
			var c = cancel;
			return System.Threading.Tasks.Task.Delay(
				procLaterPop 
				,
				c
			).ContinueWith(
				(t) =>
				{
					//if (c.IsCancellationRequested)
					//{
					//	return;
					//}
#if Symbol
					Debug.WriteLine("after delay,now we show win...");

#endif
					_TackleXpnX.Act(
						proc
						,
						title
					);
				}
				,
				c
			//,TaskContinuationOptions.NotOnCanceled
			//,null
			);

		}
		/// <summary>
		/// </summary>
		/// <returns></returns>
		public static Task Task(
			Process proc, string title = null, CancellationToken cancel = default, int? procLaterPop = null
		)
		{
			return _AsTask_lurkAssumeNum(proc,title,cancel,
				procLaterPop ?? nilnul.os.Properties.Settings.Default.procLaterPop

				);
		

		}


	}
}