using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.ui_.hid.act_.show_.title
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
			Process proc, string title, CancellationToken cancel, int? procLaterPop = null
		)
		{
			return System.Threading.Tasks.Task.Delay(
				procLaterPop??nilnul.win.Properties.Settings.Default.procLaterPop, cancel
			).ContinueWith(
				(t) =>
				{
						_TitleX.Act(
						ref proc
						,
						title
					);
				}
				,cancel
			);

		}
	}
}