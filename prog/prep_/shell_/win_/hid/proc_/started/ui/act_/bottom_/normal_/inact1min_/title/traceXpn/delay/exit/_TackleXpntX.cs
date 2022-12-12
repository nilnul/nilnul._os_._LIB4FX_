using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui.act_.bottom_.normal_.inact1min_.title.traceXpn.delay.exit
{
	/// <summary>
	/// </summary>
	public static class _TackleXpnX
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public static void Act(Process proc, string title, int? procPopLater=null)
		{
			try
			{
				_ExitX.Act(proc, title, procPopLater);
			}
			catch (Exception e)
			{

				Trace.TraceError(
					$@"{
						nilnul.os.prog.prep.Phrase.Singleton.phrase(proc.StartInfo)
					}; xpn:{e}; procPopLater:{procPopLater}; title:{title}"
				);
			}

		}
	}
}
