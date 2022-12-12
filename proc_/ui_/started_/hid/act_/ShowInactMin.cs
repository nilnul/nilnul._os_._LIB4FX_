using nilnul.win.proc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.ui_.hid.act_
{
	/// <summary>
	/// will show the ui on the desktop
	/// </summary>
	public class ShowInactMin : ActI
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public  void act(ref Process proc)
		{

			win.ui.act_.show_.inactive_._MinX._inNonNil(proc.MainWindowHandle); //shown

		}

		static public ShowInactMin Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ShowInactMin>.Instance;
			}
		}

	}

}
