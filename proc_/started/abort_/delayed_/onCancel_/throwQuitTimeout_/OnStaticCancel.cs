using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.abort_.delayed_.onCancel_.throwQuitTimeout_
{
	public class OnStaticCancel
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
		public static async void Vod(
			Process _proc_unwaited
			,
			int runAftCancel
			,
			int _user2close_positive
			,
			int _waitAftKilling_positive
		)
		{
			abort_.delayed_.onCancel_._ThrowKillingX.Vod(
				_proc_unwaited
				,
				_leave.StaticCancel.CancellationTokenSource.Token
				,
				runAftCancel
				,
				_user2close_positive
				//,
				//_waitAftKilling_positive
			);

		}

		public static void Vod(
			Process _proc_unwaited
			,
			int? life

			,
			int? minimum4user2close = null
			//,
			//int? waitAftKilling = null
		)
		{

			///we will wait for the proces later; as killing is asyn, we need the wait;
			///

			Vod(
				_proc_unwaited
				,
				os.Properties.SettingsX._Life4proc(life)

				,
				os.Properties.SettingsX._Minimal4usr2close(minimum4user2close)
				//,
				//os.Properties.SettingsX._WaitAftKilling(waitAftKilling)
			);
		}
	}
}
