using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using nilnul.str;
using nilnul.os.proc_.started.abort_;

namespace nilnul.os.proc_.started.cull_.onDue0cancel_.onStaticCancel_
{
	public class _CancellableX
	{
		/// <summary>
		/// </summary>
		/// <param name="_proc_unwaited"></param>
		/// <param name="cancelProcess">
		/// abort the process
		/// </param>
		/// <param name="lifeGiven"></param>
		/// <param name="extended4user2close"></param>
		/// <param name="waitAftKilling">o
		/// </param>
		public static Task AsTask(
			Process _proc_unwaited
			,
			int life
			,
			int _user2close_positive
			,
			int _waitAftKilling_positive
			,
			CancellationToken procWaitedToken
		)
		{
			return onDue0cancel_._CancellableX.AsTask(
				_proc_unwaited
				,
				life
				,
				_leave.StaticCancel.CancellationTokenSource.Token
				,
				_user2close_positive
				,
				_waitAftKilling_positive
				,
				procWaitedToken
			);

		}

		public static Task AsTask(
			Process _proc_unwaited
			,
			int? life
			,
			int? minimum4user2close 
			,
			int? waitAftKilling 
				,
			CancellationToken procWaitedToken
		)
		{

			///we will wait for the proces later; as killing is asyn, we need the wait;
			///

			return AsTask(
				_proc_unwaited
				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)

				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
				,
				os.Properties.SettingsX._WaitAftKilling(waitAftKilling)
				,
				 procWaitedToken

			);
		}
	}
}
