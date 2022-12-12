using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui.act_
{
	public class _Bottom_uiAssumeNonnil : nilnul.os.proc.ActI, ActI<Process>
	{
		public static _Bottom_uiAssumeNonnil Singleton => nilnul.obj_.Singleton<_Bottom_uiAssumeNonnil>.Instance;
		static public void Act_ofNonnil(IntPtr proc)
		{

			nilnul.os.ui.position_._BottomX.ShoveToBackground_assumeNotNil(proc);
		}
		static public void Act(IntPtr proc)
		{

			nilnul.os.ui.position_._BottomX.OfHandle(proc);
		}


		/// <summary>
		/// assume ui nonnil
		/// </summary>
		/// <param name="proc"></param>
		public virtual void act(ref Process proc)
		{
			var handle = os.proc._MainWinX.InTime(proc);

			Act(handle);
		}



	}
}
