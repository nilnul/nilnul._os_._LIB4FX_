using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started.ui_.invis.act_.bottom_.inact1min_.title
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
#if Symbol
				Debug.WriteLine("show with title...");

#endif

				_TitleX.Act(ref proc, title);
			}
			catch (Exception e)
			{
				nilnul.os.proc.act_._TraceAsErrX.TraceAsErr(ref proc, e);
				
			}

		}
	}
}
