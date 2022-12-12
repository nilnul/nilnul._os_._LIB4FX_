using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started_
{
	/// <summary>
	///   a cancelable process;
	/// </summary>
	public static class _AbortableX
	{
		/// <summary>
		/// </summary>
		/// <param name="_proc_unwaited"></param>
		/// <param name="cancelProcess">
		/// make the process respond to cancel signal
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
			int _user2close_positive 
		)
		{

			var processWaited = new CancellationTokenSource();

			cancel.Register(
				()=> started_.unwaited.quit_._abort.close._KillingX.EndedAsyn(
					_proc_unwaited, processWaited.Token, _user2close_positive)
			);


		}

		public static  void Vod(
			Process _proc_unwaited
			,
			CancellationToken cancel
			,
			int? minimum4user2close = null
		)
		{

			///we will wait for the proces later; as killing is asyn, we need the wait;
			///

			Vod(
				_proc_unwaited
				,
				cancel
				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
		}
	}
}
