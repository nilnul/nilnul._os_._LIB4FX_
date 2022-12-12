using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.ui_.nonnil.act_.bottom_
{
	
	public class _Inact1min_uiAssumeNonnil : _Bottom_uiAssumeNonnil
	{
		public new static _Inact1min_uiAssumeNonnil Singleton => nilnul.obj_.Singleton<_Inact1min_uiAssumeNonnil>.Instance;

		public override void act(ref Process proc)
		{
			base.act(ref proc);
			act_.normal_._Inactive1min_uiAssumeNonnil.Singleton.act(ref proc);
		}
	}
}
