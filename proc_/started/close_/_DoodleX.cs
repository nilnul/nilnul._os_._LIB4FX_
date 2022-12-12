using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.close_
{

	/// <summary>
	///given time, closing might be successful or not;
	/// 
	/// </summary>
	/// <remarks>
	/// allow the user 2close it;
	///
	/// </remarks>
	public static class _DoodleX
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
		)
		{
			bool alreadyExited = _CloseX.Exited(proc);

			if (alreadyExited)
			{
				return;
			}

			await Task.Delay(
				minimum4user2close
			); //let the usr do something;

		}

		public static void Vod(
			Process proc
			,
			int minimum4user2close
		)
		{
			bool alreadyExited = _CloseX.Exited(proc);

			if (alreadyExited)
			{
				return;
			}

			Task.Delay(
				minimum4user2close
			).Wait(); //let the usr do something;

		}

		/// <summary>
		/// if exited 0 canccled, return true; otherwise, return false if timeout
		/// </summary>
		/// <param name="proc"></param>
		/// <param name="processExitedSignal"></param>
		/// <param name="minimum4user2close"></param>
		/// <returns></returns>
		public static async Task<bool> ExitedAsyn(
			Process proc
			,
			int minimum4user2close
		)
		{
			bool alreadyExited = _CloseX.Exited(proc);

			if (alreadyExited)
			{
				return true;
			}
			await Task.Delay(
				minimum4user2close
			);
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
		[Obsolete("use the task.wait")]
		public static bool Exited(
			Process proc
			,
			int minimum4user2close
		)
		{
			var exited = _CloseX.Exited(proc);

			if (exited)
			{
				return true;
			}

			Task.Delay(
				   minimum4user2close
		   ).Wait(
			//processWaitedSignal
			);

			return proc.HasExited;


		}

	}
}
