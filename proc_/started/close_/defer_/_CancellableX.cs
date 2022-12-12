using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.close_.defer_
{

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	public static class _CancellableX
	{

		/// <summary>
		/// Exited0cancelled0timeout
		/// </summary>
		/// <param name="proc"></param>
		/// <param name="processExitedSignal"></param>
		/// <param name="minimum4user2close"></param>
		/// <returns></returns>
		public static async Task Asyn(
			Process proc
			,
			int minimum4user2close
			,
			CancellationToken processExitedSignal
		)
		{
			bool alreadyExited = _CloseX.Exited(proc);

			if (alreadyExited)
			{
				return ;
			}
			try
			{
				await Task.Delay(
					minimum4user2close
					,
					processExitedSignal
				);
			}
			catch (TaskCanceledException)
			{
				return ;
				//throw;
			}
		}

		/// <summary>
		/// if exited 0 canccled, return true; otherwise, return false if timeout
		/// </summary>
		/// <param name="proc"></param>
		/// <param name="processExitedSignal"></param>
		/// <param name="minimum4user2close"></param>
		/// <returns></returns>
		public static async Task<bool> Exited0cancelledAsyn(
			Process proc
			,
			int minimum4user2close
			,
			CancellationToken processExitedSignal
		)
		{
			bool alreadyExited = _CloseX.Exited(proc);

			if (alreadyExited)
			{
				return true;
			}
			try
			{
				await Task.Delay(
					minimum4user2close
					,
					processExitedSignal
				);
			}
			catch (TaskCanceledException)
			{
				return true;
				//throw;
			}
			////.ContinueWith(t => { });

			//if (processExitedSignal.IsCancellationRequested)
			//{
			//	return true;
			//}
			return proc.HasExited;
		}


		/// <summary>
		/// in the given time, is it exited, by popping for user intervention or by the operation of the user self?
		/// </summary>
		/// <param name="proc"></param>
		/// <param name="processWaitedSignal"></param>
		/// <param name="minimum4user2close"></param>
		/// <returns></returns>
		///
		[Obsolete("user the task.wait")]
		public static bool Exited0cancelled(
			Process proc
			,
			int minimum4user2close
			,
			CancellationToken processWaitedSignal
		)
		{
			var exited = _CloseX.Exited(proc);

			if (exited)
			{
				return true;
			}
			try
			{
				Task.Delay(
					   minimum4user2close
					   ,
					   processWaitedSignal
			   ).Wait(
				//processWaitedSignal
				);

			}
			catch (TaskCanceledException)
			{
				return true;
			}


			//if (processWaitedSignal.IsCancellationRequested)
			//{
			//	return true; // let the canceller to determine "true" means exited or killing
			//}
			return proc.HasExited;


		}

	}
}
