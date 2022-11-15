using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.win.prog._run;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_.abortable_.ended
{
	public class Result
		//: nilnul.os.prog.run_.timed_.ended.ResultA
	{
		

		public  win.prog._run.Result ofAddress(
			string cmd, string arg, string dir
			, int? minimum4usr2close = null
			, int? waitAftKilling = null

			)
		{
			using (var p = new Ended(cmd, arg, dir,  minimum4usr2close
							,    waitAftKilling 

				))
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
