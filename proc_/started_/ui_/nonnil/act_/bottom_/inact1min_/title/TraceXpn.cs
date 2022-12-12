using nilnul.os.proc.act_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.ui_.nonnil.act_.bottom_.inact1min_.title
{
	public static class _TraceXpnX
	{
		public static void Act(Process proc, string title, int? procPopLater = null)
		{
			try
			{
				_TitleX.Act(proc, title);
			}
			catch (Exception)
			{
				os.proc.act_._TraceAsErrX.TraceAsErr(ref proc);
			}
		}
	}
}
