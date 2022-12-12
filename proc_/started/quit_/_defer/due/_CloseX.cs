using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel;

namespace nilnul.os.proc_.started_.unwaited.due

{
	/// <summary>
	/// </summary>
	static public class _CloseX
	{
		/// <summary>
		/// </summary>
		/// <param name="life4proc"></param>
		/// <returns></returns>
		public static async Task<bool> _EndedAsyn(
			Process _proc_started
			,
			CancellationToken cancellationToken
			,
			int life4proc
			,
			int minimum4user2close
		)
		{

			await System.Threading.Tasks.Task.Delay(

				life4proc
				,
				cancellationToken
			);


			return await unwaited.end_._abort._CloseX.EndedAsyn(
				_proc_started
			, cancellationToken
			, minimum4user2close

			);




		}

		/// <summary>
		/// </summary>
		/// <param name="life4proc"></param>
		/// <returns></returns>
		public static  Task<bool> _EndedAsyn(
			Process _proc_started
			,
			CancellationToken cancellationToken = default
			,
			int? life4proc = null
			,
			int? minimum4user2close = null
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
