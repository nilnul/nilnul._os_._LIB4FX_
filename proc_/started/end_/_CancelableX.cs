using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.end_
{
	/// <summary>
	/// </summary>
	public static class _CancelableX
	{
		/// <summary>
		/// </summary>
		/// <param name="_proc_unwaited"></param>
		/// <param name="cancelProcess">
		/// </param>
		/// <param name="waitAftKilling">o
		/// </param>
		public static void _Vod(
			Process _proc_unwaited
			,
			CancellationToken cancel
			,
			int _waitAftKilling_positive
		)
		{
	

			bool exited = false;

			while (!exited)
			{
				exited = _proc_unwaited.WaitForExit((_waitAftKilling_positive));


				cancel.ThrowIfCancellationRequested();
			}

		}

		public static Task _Task(
			Process _proc_unwaited
			,
			CancellationToken cancel
			,
			int _waitAftKilling_positive
		)
		{

			return Task.Run(
				()=> _Vod(
					_proc_unwaited
					,
					cancel
					,
					_waitAftKilling_positive
				)
				,cancel
			);


		}

		public static void _Vod(
			Process _proc_unwaited
			,
			CancellationToken cancel
			,
			int? waitAftKilling = null
		)
		{
			_Vod(
				_proc_unwaited
				,
				cancel
				,
				os.Properties.SettingsX._WaitAftKilling(waitAftKilling)
			);
		}
	}
}
