using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.ui_.hid.act_.show_.title.traceXpn
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
			Process proc, string title=null, CancellationToken  cancel=default, int? procLaterPop = null
		)
		{
			var c = cancel;
			return System.Threading.Tasks.Task.Delay(
				procLaterPop??nilnul.win.Properties.Settings.Default.procLaterPop
				, c
			).ContinueWith(
				(t) =>
				{
						_TackleXpnX.Act(
						proc
						,
						title
					);
				}
				,c
			);

		}
	}
}