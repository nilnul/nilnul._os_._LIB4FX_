using nilnul.os.proc_.started;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.cull_.throwKilling_
{
	public static class _CancellableX
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="proc"></param>
		/// <param name="timeout2closeWin">time allowed for suicide</param>
		/// <param name="processWaited">
		///to cancel the supervising of the suicide, as
		/// </param>
		public static async Task Asyn(
			Process _proc_started
			,
			int minimum4user2close
			,
			CancellationToken processWaited
		)
		{
			var t = await close_.defer_._CancellableX.Exited0cancelledAsyn(
				_proc_started
			, minimum4user2close
			, processWaited
			);  // task excelled exception;

			if (t)
			{
				return;
			}

			if (processWaited.IsCancellationRequested)
			{
				return;
			}

			kill_._ThrowX.KillingAsXpn_exitedAsNonxpn(
				_proc_started
			);


		}

		public static void Vod(
			Process _proc_started
			,
			int minimum4user2close
			,
			CancellationToken processWaited
		)
		{

			var t = close_.defer_._CancellableX.Exited0cancelledAsyn(
			  _proc_started
			  , minimum4user2close
			  , processWaited
		  ).Result;  // task cancelled exception;

			if (t)
			{
				return;
			}

			if (processWaited.IsCancellationRequested)
			{
				return;
			}

			kill_._ThrowX.KillingAsXpn_exitedAsNonxpn(
				_proc_started
			);


		}

		public static bool BeKilling(
			Process _proc_started
			,
			int minimum4user2close, CancellationToken processWaited
		)
		{
			var t = close_.defer_._CancellableX.Exited0cancelledAsyn(
			  _proc_started
			  , minimum4user2close
			  , processWaited
		  ).Result;  // task cancelled exception;

			if (t)
			{
				return false;
			}

			if (processWaited.IsCancellationRequested)
			{
				return false;
			}

			//processWaited.ThrowIfCancellationRequested();
			_proc_started.Kill();/*The Kill method executes asynchronously. After calling the Kill method, call the WaitForExit method to wait for the process to exit, or check the HasExited property to determine if the process has exited. 
					*/
			return true;
		}

		public static bool Exit0cancelled(
				Process _proc_started
				,
				int minimum4user2close, CancellationToken processWaited
			)
		{
			var t = close_.defer_._CancellableX.Exited0cancelledAsyn(
			  _proc_started
		  , minimum4user2close, processWaited
		  ).Result;  // task cancelled exception;

			if (t)
			{
				return true;
			}

			if (processWaited.IsCancellationRequested)
			{
				return true;
			}

			//processWaited.ThrowIfCancellationRequested();
			_proc_started.Kill();/*The Kill method executes asynchronously. After calling the Kill method, call the WaitForExit method to wait for the process to exit, or check the HasExited property to determine if the process has exited. 
					*/
			return false;
		}


	}
}
