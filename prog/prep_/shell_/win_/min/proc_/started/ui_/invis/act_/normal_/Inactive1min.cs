using nilnul.os.proc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui_.invis.act_.bottom_.normal_
{
	/// <summary>
	/// will show the ui on the desktop
	/// </summary>
	public class Inactive1min : ActI
	{

		static public  void Act_ofNonnil(IntPtr handle)
		{

			os.ui.show_.normal_._Min1inactiveX._assumeNonnil(
				handle
				//proc.MainWindowHandle
			); //shown
		}

			static public  void Act(IntPtr handle)
		{

			os.ui.show_.normal_._Min1inactiveX.Act(
				handle
				//proc.MainWindowHandle
			); //shown
		}

	/// <summary>
		/// </summary>
		/// <returns></returns>
		public  void act(ref Process proc)
		{
			var win = ui_._MainX._Handle(ref proc);
			Act(win);



		}
	



		static public Inactive1min Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Inactive1min>.Instance;
			}
		}

	}

}
