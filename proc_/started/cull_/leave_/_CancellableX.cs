using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.cull_.leave_
{
	/// <summary>
	/// doesnot care whether the killing is successful; let the os handle it;
	/// </summary>
	/// alias:
	///		leave
	///		rot
	///		decay
	///		
	public static class _CancellableX
	{
		/// <summary>
		/// </summary>
		/// <param name="_proc_unwaited"></param>
		/// <param name="cancelProcess">abort the process
		/// </param>
		/// <param name="lifeGiven"></param>
		/// <param name="extended4user2close"></param>
		/// <param name="waitAftKilling">only this time is not cancellable</param>
		/// <exception cref="TimeoutException">
		///		not end after wait
		/// </exception>
		/// <exception cref="Win32Exception">
		/// //The wait setting could not be accessed;
		/// </exception>
		public static void Vod(
			Process _proc_unwaited
			,
			int _user2close_positive
			,
			CancellationToken cancel
		)
		{


			var closed = close_.defer_._CancellableX.Exited0cancelledAsyn(
				_proc_unwaited
				, _user2close_positive
				, cancel
			).Result;

			if (closed) { return ; }
			if (cancel.IsCancellationRequested)
			{
				return ;
			}
			 _KillX.Vod_exitedAsNonxpn(_proc_unwaited);


		}

		public static async Task Asyn(
			Process _proc_unwaited
			,
			int _user2close_positive
			,
			CancellationToken cancel
		)
		{
			var closed = await close_.defer_._CancellableX.Exited0cancelledAsyn(
				_proc_unwaited
				, _user2close_positive
				, cancel
			);

			if (closed) { return ; }
			if (cancel.IsCancellationRequested)
			{
				return ;
			}
			 _KillX.Vod_exitedAsNonxpn(_proc_unwaited);
		}

		public static void Vod(
			Process _proc_unwaited
			,
			int? minimum4user2close 
			,
			CancellationToken cancel
		)
		{
			 Vod(
			   _proc_unwaited
			   ,
			   os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
			   ,
			   cancel
		   );
		}

		public static  Task Task(
			Process _proc_unwaited
			,
			int? minimum4user2close 
			,
			CancellationToken cancel
		)
		{
			 return Asyn(
			   _proc_unwaited
			   ,
			   os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
			   ,
			   cancel
		   );
		}

		/*The source code for Process.Kill() in shows setting the exit code to -1 (as of Sep 2012). The Windows operating system actually uses 32-bit unsigned values for the exit codes but I believe the signed->unsigned->signed translations in C# should work (I only need to check for zero or non-zero so it doesn't matter for my code).
On the other hand, this is obviously undocumented behavior (Why?) so Microsoft could change it tomorrow and break my code by setting the exit code to 0.

2 processes, a parent process and a child process. The parent process controls the lifecycle of child process i.e. parent process launches the child process when it needs the child to do some work and also it kills the child when it is done with it. To kill the child process, parent process is using Process.Kill() and process.WaitForExit() APIs. 
Questions: - 
I am observing that the exit code of the child process is always -1.  

			


In general, a process is terminated using TerminateProcess. The exit code is passed as a parameter to this method.
In the case of the task manager, the exit code is set to 1, but I don't know if it's documented anywhere.
			 */

	

	}
}
