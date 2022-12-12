using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui.act_.bottom_.inact1min_.title.traceXpn
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
			var t=_DelayX.Task(proc, title, cancellationSrc.Token, procPopLater);
			proc.WaitForExit();
			cancellationSrc.Cancel();

		}
	}
}
