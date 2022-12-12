using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.ui_.hid.act_.show_
{
	/// <summary>
	/// make this a task
	/// </summary>
	public static class _TitleX
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public static void Act(ref Process proc, string title=null)
		{
			ShowInactMin.Singleton.act(ref proc);
			nilnul.win.proc.act_.ui_.title_._DirFirstX.Void_ofHandleNotNil(
				proc
				,
				title
			);
		}
	}
}
