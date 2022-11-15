using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.win.prog._run;
using nilnul.win.proc_.nonshell_.redirStd_.redirErr_.errAsyn_.stdAsyn_.started_;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_.ended
{
	[Obsolete(nameof(proc_.errAsyn_.started_.timed_.stdSyn_.ended.Result) + " is preferred as this brings about a weird issue: the line breaks are gone even if we add line breaks manually;", true)]

	public class Result : nilnul.win.proc_.started_.end.ResultA
	{
		

	

		public override win.prog._run.Result ofAddress(string cmd, string arg, string dir)
		{
			using (var p = new Ended(cmd,arg,dir) )
			{
				return p.result;
			}

		}

		static public Result Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Result>.Instance;
			}
		}

	}
}
