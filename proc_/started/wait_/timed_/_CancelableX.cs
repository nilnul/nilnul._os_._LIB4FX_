using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.wait_.timed_
{
	/// <summary>
	/// </summary>
	public static class _CancelableX
	{
		/// <summary>
		/// </summary>
		/// <param name="_proc_unwaited"></param>
		/// <param name="cancelProcess">
		/// </param>
		/// <param name="waitAftKilling">o
		/// </param>


		/// <summary>
		/// Waits asynchronously for the process to exit.
		/// </summary>
		/// <param name="process">The process to wait for cancellation.</param>
		/// <param name="cancellationToken">A cancellation token. If invoked, the task will return 
		/// immediately as canceled.</param>
		/// <returns>A Task representing waiting for the process to end.</returns>
		public static Task<bool> _ExitedAsTask(
			this Process process,
			int milliseconds,
			CancellationToken cancellationToken //= default(CancellationToken)
		) =>
		 Task.Run(
			 () => process.WaitForExit(milliseconds),
			 cancellationToken
		);




	}
}
