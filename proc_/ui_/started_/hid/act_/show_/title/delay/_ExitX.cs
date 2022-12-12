using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.ui_.hid.act_.show_.title
{
	/// <summary>
	/// make this a task
	/// </summary>
	public static class _ExitX
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public static void Act(Process proc, string title, int? procPopLater)
		{
			var cancellationSrc = new CancellationTokenSource();
			var t=show_.title._DelayX.Task(proc, title, cancellationSrc.Token, procPopLater);
			proc.WaitForExit();
			cancellationSrc.Cancel();

		}
	}
}
