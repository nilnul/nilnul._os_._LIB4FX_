using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel;

namespace nilnul.os.proc_.started_.deadlined._end

{
	/// <summary>
	/// </summary>
	static public class _KillX
	{
		/// <summary>
		/// </summary>
		/// <param name="life4proc"></param>
		/// <returns></returns>
		public static async Task<bool> _EndedAsyn(
			Process _proc_started
			,
			CancellationToken processWaited
			,
			int life4proc
			,
			int minimum4user2close
		)
		{

			await System.Threading.Tasks.Task.Delay(

				life4proc
				,
				processWaited
			);

			return await started_.unwaited.close._KillingX.EndedAsyn(
				_proc_started
				,
				processWaited
				,
				minimum4user2close
			);
		}

		/// <summary>
		/// </summary>
		/// <param name="life4proc"></param>
		/// <returns></returns>
		public static  Task<bool> _EndedAsyn(
			Process _proc_started
			,
			CancellationToken cancellationToken 
			,
			int? life4proc 
			,
			int? minimum4user2close 
		)
		{
			return _EndedAsyn(
				_proc_started
				,
				cancellationToken
				,
				os.Properties.SettingsX._Life4proc(life4proc)
				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
			);
		}

	}
}
