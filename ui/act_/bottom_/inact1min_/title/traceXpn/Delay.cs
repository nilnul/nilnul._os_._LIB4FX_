using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.ui.act_.bottom_.inact1min_.title.traceXpn
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
			IntPtr proc, string title = null, int? procLaterPop = null, CancellationToken cancel = default
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