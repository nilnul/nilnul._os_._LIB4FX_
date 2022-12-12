using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.quit_
{

	public static class _EnsureExitedInTimeX
	{

		public static void Vod(
			Process _proc_unwaited
			,
			int _waitAftKilling_positive
		)
		{
			if (started._KillX.Exited(_proc_unwaited))
			{
				return;
			}

			started.wait_._VowExitedInTimeX.Vod(_proc_unwaited, _waitAftKilling_positive);
		}

		public static void Vod(
			Process _proc_unwaited
			,
			int? waitAftKilling = null
		)
		{

			///we will wait for the proces later; as killing is asyn, we need the wait;
			///

			Vod(
				_proc_unwaited
				,
				os.Properties.SettingsX._WaitAftKilling(waitAftKilling)
			);
		}
	}
}
