using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel;

namespace nilnul.os.proc_.started.cull_

{
	/// <summary>
	/// </summary>
	static public class _DelayedX
	{
		/// <summary>
		/// </summary>
		/// <param name="life4proc"></param>
		/// <returns></returns>
		public static async Task<bool> _ExitedAsyn(
			Process _proc_started
			,
			int life4proc
			,
			int minimum4user2close
		)
		{

			await System.Threading.Tasks.Task.Delay(

				life4proc
	
			);
			return await _CullX.ExitedAsyn(_proc_started,minimum4user2close);
	

		}

		/// <summary>
		/// </summary>
		/// <param name="life4proc"></param>
		/// <returns></returns>
		public static  Task<bool> _ExitedAsTask(
			Process _proc_started
			,
			int? life4proc 
			,
			int? minimum4user2close 
		)
		{
			return _ExitedAsyn(
				_proc_started
				,
				os.Properties.SettingsX._Life4proc(life4proc)
				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
			);
		}

	}
}
