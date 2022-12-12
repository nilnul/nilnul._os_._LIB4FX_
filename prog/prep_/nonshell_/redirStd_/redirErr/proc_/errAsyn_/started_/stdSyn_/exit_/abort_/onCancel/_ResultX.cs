using nilnul.os.proc_.finished._result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.started_.stdSyn_.exit_.abort_.onCancel
{
	static public class _ResultX //: nilnul.os.prog.run_.quit.ResultA
	{
		public static  nilnul.os.proc_.finished._result.CodMsgErr OfAddress(string cmd, string arg, string dir,CancellationToken cancel, int? minimum4usr2close=null, int? waitAftKilling=null)
		{
			using (
				var p = new OnCancel(cmd,arg,dir, cancel,minimum4usr2close,waitAftKilling)
			)
			{
				return p.result;
			}

		}

	
	}
}
