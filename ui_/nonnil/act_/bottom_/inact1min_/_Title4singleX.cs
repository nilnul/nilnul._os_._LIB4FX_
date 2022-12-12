using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace nilnul.os.ui_.nonnil.act_.bottom_.inact1min_
{
	/// <summary>
	/// make this a task
	/// </summary>
	public static class _TitleX
	{

		/// <summary>
		/// it seems the title is set; but when we click it to normally show it, the title restores to the file(prog)Name
		/// </summary>
		/// <returns></returns>
		public static void Act(IntPtr ui, string title)
		{

			act_.bottom_.Inact1min._Act_assumeNonnil(ui);
			///todo: set title not working on hidden window?
			nilnul.os.ui_.nonnil._TitleX.Act(ui, title 	);

		}
	}
}
