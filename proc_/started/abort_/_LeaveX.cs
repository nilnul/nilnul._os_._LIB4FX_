using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.abort_
{
	/// <summary>
	/// doesnot care whether the killing is successful; let the os handle it;
	/// </summary>
	/// alias:
	///		leave
	///		rot
	///		decay
	///		
	public static class _LeaveX
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
		public static void Leave(
			Process _proc_unwaited
			,
			int _user2close_positive
		)
		{
			using (var processWaited = new CancellationTokenSource())
			{
				close_.defer_._CancellableX.Asyn(
					_proc_unwaited
					, _user2close_positive
					, processWaited.Token
				);
				bool exited = _proc_unwaited.WaitForExit(
					_user2close_positive
				); //may be proc is already killed
				processWaited.Cancel();
				if (!exited)
				{
					started._KillX.Vod_exitedAsNonxpn(_proc_unwaited);
				}
			}
		}
	

		public static void Leave(
			Process _proc_unwaited
			,
			int? minimum4user2close = null
		)
		{
	

			 Leave(
				_proc_unwaited
				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
			);
		}
	}
}
