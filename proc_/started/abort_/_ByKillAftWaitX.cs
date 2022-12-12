using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.abort_
{
	/// <summary>
	/// two threads:
	///		1) the process discourses itself;
	///		2) a killer; when cancelling, we will terminate the process (allowing some time for it to clean up;);
	///	coordinate:
	///		1) if the process ends early, killer will ignore the cancelling;
	///		2) when the user knows that the process has been ended, he will not call killer; he will call killer only when he is not sure whether the process has been ended; the killer will end the process;
	/// </summary>
	/// alias:
	///		waitOut,
	///			analog to timeout
	///		resign
	///			the process is an employee who resigns, leave workd done or not;
	///		retire
	///		request
	///		
	public static class _ByKillAftWaitX
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
		public static bool Exited(
			Process _proc_unwaited
			,
			int _user2close_positive
			,
			int _waitAftKilling_positive
		)
		{
			using (var processWaited = new CancellationTokenSource())
			{
				close_.defer_._CancellableX.Exited0cancelledAsyn(
					_proc_unwaited
					, _user2close_positive
					, processWaited.Token
				);

				bool exited = _proc_unwaited.WaitForExit(
					(_user2close_positive + _waitAftKilling_positive)); //may be proc is already killed

				processWaited.Cancel();

				if (!exited)
				{
					return _KillX.Exited(_proc_unwaited);

				}
				return exited;


			}
		}

		public static bool Exited(
			Process _proc_unwaited
			,
			int? minimum4user2close = null
			,
			int? waitAftKilling = null
		)
		{

	

			return Exited(
				_proc_unwaited
				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
				,
				os.Properties.SettingsX._WaitAftKilling(waitAftKilling)
			);
		}
	}
}
