using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.started_.stdSyn_.exit_.abort_.delayed_.onDue0cancel
{
	static public class _ResultX //: nilnul.os.prog.run_.quit.ResultA
	{
		public static  nilnul.os.proc_.finished._result.CodMsgErr OfAddress(string cmd, string arg, string dir,
			int? life
			,
			CancellationToken cancellationToken
			, int? runAftCancel = null, int? closing = null, int? wait = null)
		{
			using (
				var p = new OnDue0cancel(cmd,arg,dir, life, cancellationToken, runAftCancel,closing, wait)
			)
			{
				return p.result;
			}

		}



	}
}
