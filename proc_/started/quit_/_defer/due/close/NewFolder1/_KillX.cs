using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.unwaited.due.close
{
	/// <summary>
	/// abort the process; given a time to let the process die by itself
	/// <see cref="proc_.IStarted"/> might already be ended;
	/// </summary>
	public static class _KillingX
	{
		/*The source code for Process.Kill() in shows setting the exit code to -1 (as of Sep 2012). The Windows operating system actually uses 32-bit unsigned values for the exit codes but I believe the signed->unsigned->signed translations in C# should work (I only need to check for zero or non-zero so it doesn't matter for my code).
On the other hand, this is obviously undocumented behavior (Why?) so Microsoft could change it tomorrow and break my code by setting the exit code to 0.

2 processes, a parent process and a child process. The parent process controls the lifecycle of child process i.e. parent process launches the child process when it needs the child to do some work and also it kills the child when it is done with it. To kill the child process, parent process is using Process.Kill() and process.WaitForExit() APIs. 
Questions: - 
I am observing that the exit code of the child process is always -1.  

			


In general, a process is terminated using TerminateProcess. The exit code is passed as a parameter to this method.
In the case of the task manager, the exit code is set to 1, but I don't know if it's documented anywhere.
			 */

		/// <summary>
		/// 
		/// </summary>
		/// <param name="proc"></param>
		/// <param name="timeout2closeWin">time allowed for suicide</param>
		/// <param name="cancel">
		///to cancel the supervising of the suicide, as
		/// </param>
		public static async Task< bool> EndedAsyn(
			Process _proc_started
			,
			CancellationToken cancel
			,
			int? life
			,
			int? minimum4user2close= null
			,
			int? extended4user2close=null
			)
		{


			var t = await unwaited.due._CloseX._EndedAsyn(
				_proc_started
				,
				cancel
				,
				life,
				minimum4user2close
				,
				extended4user2close
			);


			if (t)
			{
				return true;
			}

			try
			{
				_proc_started.Kill();/*The Kill method executes asynchronously. After calling the Kill method, call the WaitForExit method to wait for the process to exit, or check the HasExited property to determine if the process has exited. 
					*/
				/*
				InvalidOperationException 
The process has already exited. 
-or- There is no process associated with this Process object.
				 */

			}
			catch (System.InvalidOperationException)
			{

				return true;
			}
			return false;

		}


	}
}
