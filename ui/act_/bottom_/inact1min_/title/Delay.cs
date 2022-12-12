using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.ui.act_.bottom_.inact1min_.title
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
			IntPtr proc, string title, int? procLaterPop , CancellationToken processExited
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
						 proc
						,
						title
					);
				}
				, processExited
			);

		}
	}
}