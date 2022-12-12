using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_.exit
{
	[Obsolete(nameof(proc_.errAsyn_.started_.doodle_.stdSyn_.exit.Result) + " is preferred as this brings about a weird issue: the line breaks are gone even if we add line breaks manually;", true)]

	public class Result : nilnul.os.prog.run_.exit.ResultA
	{
		

	

		public override nilnul.os.proc_.finished._result.CodMsgErr ofAddress(string cmd, string arg, string dir)
		{
			using (var p = new Quit(cmd,arg,dir) )
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
