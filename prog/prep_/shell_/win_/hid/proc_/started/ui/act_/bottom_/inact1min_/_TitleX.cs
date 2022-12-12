using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui.act_.bottom_.inact1min_
{
	/// <summary>
	/// make this a task
	/// </summary>
	///
	[Obsolete("set title not work if normalizing step is ommited;")]

	public static class _TitleX
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public static void Act(ref Process proc, string title = null, int wait4input = 1000)
		{
			//_Title_uis5procX.Act(ref proc,title,wait4input);
			_Title_uiByProcX.Act(ref proc,title,wait4input);

		}
	}
}
