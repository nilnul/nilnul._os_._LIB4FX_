using nilnul.os.proc_.started_.ui_.hid.act_.show_.title;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.ui_.hid.act_.show_.title.traceXpn.delay.exit
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
			catch (Exception)
			{
				Trace.TraceError(
					$@"{
						nilnul.win.prog._run.info.Phrase.Singleton.phrase(proc.StartInfo)
					}/{nilnul.win.proc.Phrase.Singleton.phrase(proc)}"
				);
			}

		}
	}
}
