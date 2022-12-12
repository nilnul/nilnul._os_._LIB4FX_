using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel;

namespace nilnul.os.proc_.started.cull_.delayed_

{
	/// <summary>
	/// </summary>
	static public class _CancellableX
	{
		/// <summary>
		/// </summary>
		/// <param name="life4proc"></param>
		/// <returns></returns>
		public static async Task<bool> _Exit0cancelledAsyn(
			Process _proc_started
			,
			int life4proc
			,
			int minimum4user2close
			,
			CancellationToken processWaited
		)
		{

			await System.Threading.Tasks.Task.Delay(

				life4proc
				,
				processWaited
			).ContinueWith(t => { } );
			if (processWaited.IsCancellationRequested)
			{
				return true;
			}

			return await started.cull_._CancellableX.Exited0cancelledAsyn(
				_proc_started
				,
				minimum4user2close
				,
				processWaited
			);
		}

		/// <summary>
		/// </summary>
		/// <param name="life4proc"></param>
		/// <returns></returns>
		public static  Task<bool> _Exit0cancelledAsTask(
			Process _proc_started
			,
			int? life4proc 
			,
			int? minimum4user2close 
			,
			CancellationToken cancellationToken 
		)
		{
			return _Exit0cancelledAsyn(
				_proc_started
				,
				os.Properties.SettingsX._Life4proc(life4proc)
				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
				,
				cancellationToken
			);
		}

	}
}
