using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui.show_.normal_.inact1min_
{
	/// <summary>
	/// make this a task
	/// </summary>
	/// <see cref="nilnul.os.proc.act_._TraceAsErrX"/>
	public static class _TitleX
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public static void Act(ref Process proc, string title=null)
		{
			Trace.TraceInformation("show window...");

			Inactive1min.Singleton.act(ref proc);

			Trace.TraceInformation("show title...");
			nilnul.os.proc_.started.ui._TitleX.TitleNulable(
				proc
				,
				title
			);
		}
	}
}
