using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.ui_.nonnil.act_.bottom_.inact1min_.title.traceXpn.delay.waitOut
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
				_WaitOutX.Act(proc, title, procPopLater);
			}
			catch (Exception)
			{
				os.proc.act_._TraceAsErrX.TraceAsErr(ref proc);
			}

		}
	}
}
