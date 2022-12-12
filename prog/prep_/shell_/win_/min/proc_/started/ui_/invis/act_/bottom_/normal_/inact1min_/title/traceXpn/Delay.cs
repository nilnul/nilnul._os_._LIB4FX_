using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started.ui_.invis.act_.bottom_.inact1min_.title.traceXpn
{
	/// <summary>
	/// make this a task
	/// </summary>
	public static class _DelayX
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public static Task Task(
			Process proc, string title = null, int? procLaterPop = null, CancellationToken cancel = default
		)
		{
			var c = cancel;
			return System.Threading.Tasks.Task.Delay(
				procLaterPop ?? nilnul.os.Properties.Settings.Default.procLaterPop
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
	}
}