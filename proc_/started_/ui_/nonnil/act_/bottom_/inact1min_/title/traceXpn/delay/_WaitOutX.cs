using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.ui_.nonnil.act_.bottom_.inact1min_.title.traceXpn.delay
{
	/// <summary>
	/// make this a task
	/// </summary>
	public static class _WaitOutX
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
