using nilnul.os.proc_.started;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started
{
	public static class _CullX
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
		/// <param name="processWaited">
		///to cancel the supervising of the suicide, as
		/// </param>
		public static async Task<bool> ExitedAsyn(
			Process _proc_started
			,
			int minimum4user2close
		)
		{

			var t= await close_._DoodleX.ExitedAsyn(
				_proc_started
			, minimum4user2close
			);  

			if (t)
			{
				return true;
			}

			return proc_.started._KillX.Exited(_proc_started);
	

		}

		public static async Task LeaveAsyn(
			Process _proc_started
			,
			int minimum4user2close
		)
		{

			var t= await close_._DoodleX.ExitedAsyn(
				_proc_started
			, minimum4user2close
			);  

			if (t)
			{
				return ;
			}
			 proc_.started._KillX.Vod_exitedAsNonxpn(_proc_started);
	
		}

		public static void Leave(
			Process _proc_started
			,
			int minimum4user2close
		)
		{

			 var t=close_._DoodleX.Exited(
				_proc_started
				, minimum4user2close
			);  

			if (t)
			{
				return ;
			}
			 proc_.started._KillX.Vod_exitedAsNonxpn(_proc_started);
	
		}






	}
}
