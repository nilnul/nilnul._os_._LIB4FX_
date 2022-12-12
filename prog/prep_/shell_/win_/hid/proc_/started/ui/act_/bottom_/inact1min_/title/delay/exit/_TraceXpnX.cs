using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui.act_.bottom_.inact1min_.title.exit
{
	/// <summary>
	/// </summary>
	public static class _TraceXpnX
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
						nilnul.os.prog.prep.Phrase.Singleton.phrase(proc.StartInfo)
					};title:{title}; lurk:{procPopLater};"
				);
			}

		}
	}
}
