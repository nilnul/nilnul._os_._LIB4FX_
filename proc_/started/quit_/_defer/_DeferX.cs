using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel;

namespace nilnul.os.proc_.started_.unwaited.close.kill_

{
	/// <summary>
	/// </summary>
	/// 
	static public class _DeferX
	{
		/// <summary>
		/// </summary>
		/// <param name="life4proc"></param>
		/// <returns></returns>
		public static async Task<bool> _TaskOfEnded(
			Process _proc_started
			,
			CancellationToken cancellationToken = default
			,
			int? life4proc = null
			,
			int? minimum4user2close=null
			,
			int? extended4user2close = null
		)
		{
			try
			{
				await System.Threading.Tasks.Task.Delay(
					life4proc
					??
					nilnul.func._TryX.Try(
						() =>
						{
							try
							{
								return nilnul.win.Properties.Settings.Default?.procLife;
							}
							catch (Exception)
							{
								return null;
							}
						}
					)

					??

					int.Parse(
						(string)
						nilnul.win.Properties.Settings.Default.Properties[nameof(nilnul.win.Properties.Settings.Default.procLife)].DefaultValue

					)

					,
					cancellationToken
				);
			}
			catch (TaskCanceledException)
			{

				///not take time; in urgency;
			}



			return await _KillX.TaskOfEnded(
				_proc_started
			, cancellationToken
			,minimum4user2close
				,
				extended4user2close
			);




		}


	}

}
