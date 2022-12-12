using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace nilnul.os.proc_.started_.ui_.nonnil.act_.bottom_.inact1min_
{
	public static class _TitleX
	{
		public static void Act(Process proc, string title = null)
		{
			//may be the process run2end, or user closed; so:

			var handle = proc_.started.ui_._MainX.Attempted(proc);
			if (handle ==default)
			{
				return;

			}
			os.ui_.nonnil.act_.bottom_.normal_.inact1min_._TitleX.Act(
				handle
				,
				title
			);

			//_Inact1min_uiAssumeNonnil.Singleton.act(ref proc);
			//started.ui._TitleX.TitleNulable(proc, title);
		}
	}
}
