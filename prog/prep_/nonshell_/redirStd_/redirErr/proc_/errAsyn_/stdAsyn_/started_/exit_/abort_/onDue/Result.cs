using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_.exit_.abort_.onDue
{
	[Obsolete(nameof(proc_.errAsyn_.started_.doodle_.stdSyn_.exit.Result) + " is preferred as this brings about a weird issue: the line breaks are gone even if we add line breaks manually;", true)]

	public class Result
		//: nilnul.os.prog.run_.quit_.onDue.ResultA
	{
		

		public os.proc_.finished._result.CodMsgErr ofAddress(
			string cmd, string arg, string dir
			
			, int? life = null
			, int? minimum4usr2close = null
			, int? waitAftKilling = null

			)
		{
			using (
				var p = new OnDue(cmd, arg, dir, life, minimum4usr2close
					,    waitAftKilling 

			))
			{
				return p.result();
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
