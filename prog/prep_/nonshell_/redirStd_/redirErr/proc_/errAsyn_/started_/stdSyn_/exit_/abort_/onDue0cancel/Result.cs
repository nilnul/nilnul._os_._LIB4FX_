using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.started_.stdSyn_.exit_.abort_.onDue0cancel
{
	public class Result
		//:
		//nilnul.os.prog.run_.quit_.onDue.ResultA
		//,

		//nilnul.os.prog.run_.quit.ResultI
	{
		public nilnul.os.proc_.finished._result.CodMsgErr ofAddress(string cmd, string arg, string dir, int? life , CancellationToken cancel, int? bye = null
	, int? waitAftKill = null
	)
		{
			using (var p = new OnDue0cancel(cmd, arg,
				nilnul.fs.address.nulable.to_._OverlongX.PrependIfNeed(dir)
				//dir
				, life, cancel, bye, waitAftKill))
			{
				return p.result;
			}

		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cmd"></param>
		/// <param name="arg"></param>
		/// <param name="dir"></param>
		/// <param name="life"></param>
		/// <param name="bye">how long to wait to kill the program after an end request is sent out</param>
		/// <returns></returns>
		public  nilnul.os.proc_.finished._result.CodMsgErr ofAddress(string cmd, string arg, string dir,int? life , CancellationToken cancel,  int? bye = null

			)
		{
			return ofAddress(
				cmd,
				arg,
				dir,
				life
				,cancel
				,
				bye
				,
				null
			);

		}

		public  nilnul.os.proc_.finished._result.CodMsgErr ofAddress(string cmd, string arg, string dir)
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
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Result>.Instance;
			}
		}

	}
}
