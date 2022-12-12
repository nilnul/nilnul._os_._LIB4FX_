using nilnul.os.proc_.started;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.cull_
{
	public static class _ThrowKillingX
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
		)
		{
			var t = await close_._DoodleX.ExitedAsyn(
				_proc_started
			, minimum4user2close
			);  // task excelled exception;

			if (t)
			{
				return;
			}

			started.kill_._ThrowX.KillingAsXpn_exitedAsNonxpn(_proc_started);

		

		}

		public static void Vod(
			Process _proc_started
			,
			int minimum4user2close
		)
		{

			var t = close_._DoodleX.ExitedAsyn(
			  _proc_started
		  , minimum4user2close
		  ).Result;  // task cancelled exception;

			if (t)
			{
				return;
			}
			started.kill_._ThrowX.KillingAsXpn_exitedAsNonxpn(_proc_started);


		}




	}
}
