using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_.exit_.abort_.onDue0cancel
{
	public class Result
		//: nilnul.os.prog.run_.quit_.onDue.ResultA
	{
		

		public os.proc_.finished._result.CodMsgErr ofAddress(
			string cmd, string arg, string dir
			,
			CancellationToken cancel
			
			, int? life = null
			, int? minimum4usr2close = null
			, int? extended4usr2close = null
			, int? waitAftKilling = null

			)
		{
			using (
				var p = new OnDue0cancel(cmd, arg, dir, cancel,life, minimum4usr2close
					,  extended4usr2close ,  waitAftKilling 

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
