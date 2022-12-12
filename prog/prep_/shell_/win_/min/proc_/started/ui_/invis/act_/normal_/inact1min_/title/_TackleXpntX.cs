using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui.show_.normal_.inact1min_.title
{
	/// <summary>
	/// </summary>
	public static class _TackleXpnX
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public static void Act(Process proc, string title=null)
		{
			try
			{
				Trace.TraceInformation("show with title...");
				_TitleX.Act(ref proc, title);
			}
			catch (Exception)
			{
				nilnul.os.proc.act_._TraceAsErrX.TraceAsErr(ref proc);
				
			}

		}
	}
}
