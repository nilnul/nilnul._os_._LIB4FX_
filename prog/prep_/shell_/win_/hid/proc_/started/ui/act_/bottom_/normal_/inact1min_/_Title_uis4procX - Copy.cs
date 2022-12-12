using nilnul.obj.str;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui.act_.bottom_.normal_.inact1min_
{
	/// <summary>
	/// make this a task
	/// </summary>
	public static class _Title_uis5procX
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public static void Act(ref Process proc, string title = null, int wait4input = 1000)
		{

			var t = proc;
			//var threadWin =
				os.uis._FindX.Handles(proc).Each(
					u=>os.ui_.nonnil.act_.bottom_.normal_.inact1min_._TitleX.Act(
						u, title ?? nilnul.os.proc.prep.Phrase.Singleton.phrase(t)
					)
			);
				

		}
	}
}
