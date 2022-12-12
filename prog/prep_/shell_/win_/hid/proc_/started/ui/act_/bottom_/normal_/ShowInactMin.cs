using nilnul.os.proc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui.act_.bottom_.normal_
{
	/// <summary>
	/// will show the ui on the desktop
	/// </summary>
	public class Inact1min : act_._Bottom_uiAssumeNonnil
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public  static void Act(IntPtr handle)
		{
			if (handle== default)
			{
				return;
			}
			Act_ofNonnil(handle); //shown

		}
		public  static void Act_ofNonnil(IntPtr handle)
		{

			_Bottom_uiAssumeNonnil.Act_ofNonnil(handle);

			//base.act(ref proc);
			os.ui.show_.normal_._Min1inactiveX._assumeNonnil(handle); //shown

		}

		public  override void act(ref Process proc)
		{
			var handle = os.proc._MainWinX.InTime( proc);
			
			Act(handle);

			


		

		}


		static public Inact1min Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Inact1min>.Instance;
			}
		}

	}

}
