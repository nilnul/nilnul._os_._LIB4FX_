using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_.min.proc_.errAsyn_.started_.stdSyn_.ended
{
	public class Result : nilnul.os.prog.run_.ended.ResultA
	{
		public override nilnul.os.proc_.finished._result.CodMsgErr ofAddress(string cmd, string arg, string dir)
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
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Result>.Instance;
			}
		}

	}
}
