using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.wait_
{

	public static class _VowExitedInTimeX
	{

		public static void Vod(
			Process _proc_unwaited
			,
			int _waitAftKilling_positive
		)
		{

			if (
				_proc_unwaited.WaitForExit(
					_waitAftKilling_positive)
			)
			{
				throw new proc_.started.wait_.exit_.xpn_.Timeout(
					$"{_proc.prep.phrase_._DirCmdArgX.Phrase(_proc_unwaited.StartInfo)} had been killed; and we waited for {_waitAftKilling_positive} and it still doesnot end; maybe it's not responding?"
				);

			}


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
