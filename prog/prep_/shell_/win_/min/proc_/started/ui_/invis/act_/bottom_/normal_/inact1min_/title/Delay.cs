using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started.ui_.invis.act_.bottom_.inact1min_.title
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
			Process proc, string title, CancellationToken processExited, int? procLaterPop = null
		)
		{

			return System.Threading.Tasks.Task.Delay(
				procLaterPop ?? nilnul.os.Properties.Settings.Default.procLaterPop, processExited
			).ContinueWith(
				(t) =>
				{
					//if (processExited.IsCancellationRequested)
					//{
					//	return;
					//}
					_TitleX.Act(
					ref proc
					,
					title
				);
				}
				, processExited
			);

		}
	}
}