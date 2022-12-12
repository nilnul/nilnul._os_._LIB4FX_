using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.cull_.leave_.delayed_
{
	/// <summary>
	///  end or leave a cancelable process;
	/// </summary>
	public static class _OnCancelX
	{
		/// <summary>
		/// run infinitelly until cancel
		/// </summary>
		/// <param name="_proc_unwaited"></param>
		/// <param name="cancelProcess">
		/// abort the process
		/// </param>
		/// <param name="lifeGiven"></param>
		/// <param name="extended4user2close"></param>
		/// <param name="waitAftKilling">o
		/// </param>
		public static void Vod(
			Process _proc_unwaited
			,
			CancellationToken cancel
			,
			int delay
			,
			int closing
		)
		{


			var registered = cancel.Register(
				() => cull_.leave_._DelayedX._LeaveAsyn(
					_proc_unwaited
					, delay
					,
					closing
				)
			);

	


		}

		public static void Vod(
			Process _proc_unwaited
			,
			CancellationToken canel
			,
			int? minimum4user2close = null
			,
			int? waitAftKilling = null
		)
		{

			///we will wait for the proces later; as killing is asyn, we need the wait;
			///

			Vod(
				_proc_unwaited
				,
				canel
				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
				,
				os.Properties.SettingsX._WaitAftKilling(waitAftKilling));
		}
	}
}
