using nilnul.os.proc_.started;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.kill_
{
	/// <summary>
	/// benighn exp is ignored;
	/// </summary>
	public static class _ThrowX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="proc"></param>
		/// <param name="timeout2closeWin">time allowed for suicide</param>
		/// <param name="processWaited">
		///to cancel the supervising of the suicide, as
		/// </param>


		public static void KillingAsXpn_exitedAsNonxpn(
			Process _proc_started
		)
		{
			_KillX.Vod_exitedAsNonxpn(_proc_started);
			throw new kill_.xpn_.ThouShaltNotKill(_proc_started);


		}

	}
}
