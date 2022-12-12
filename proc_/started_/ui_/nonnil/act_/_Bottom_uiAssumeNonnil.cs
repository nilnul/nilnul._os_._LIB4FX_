using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.ui_.nonnil.act_
{
	public class _Bottom_uiAssumeNonnil : nilnul.os.proc.ActI, ActI<Process>
	{
		public static _Bottom_uiAssumeNonnil Singleton => nilnul.obj_.Singleton<_Bottom_uiAssumeNonnil>.Instance;

		/// <summary>
		/// assume ui nonnil
		/// </summary>
		/// <param name="proc"></param>
		public virtual void act(ref Process proc)
		{
			nilnul.os.ui.position_._BottomX._OvHandleNotNil(proc);
		}
	}
}
