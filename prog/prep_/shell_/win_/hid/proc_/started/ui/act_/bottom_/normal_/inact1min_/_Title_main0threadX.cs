﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui.act_.bottom_.normal_.inact1min_
{
	/// <summary>
	/// make this a task
	/// </summary>
	public static class _Title_main0threadX
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public static void Act(ref Process proc, string title = null, int wait4input = 1000)
		{
#if Symbol
			Debug.WriteLine("show window...");

#endif


			var threadWin = os.proc_.started.ui_._MainX.Attempted(proc,wait4input)
				;

			if (threadWin==default)
			{
				threadWin=os.prog.prep_.shell_.win_.hid.proc_.started._UiX.ThreadWinFirst0default(proc);

			}


			if (threadWin == default)
			{
				return;
			}

			os.ui_.nonnil.act_.bottom_.normal_.inact1min_._TitleX.Act(threadWin, title ?? nilnul.os.proc.prep.Phrase.Singleton.phrase(proc));

		}
	}
}
