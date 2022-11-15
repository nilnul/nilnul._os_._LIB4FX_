using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.timed_.cancelable_.ended.result
{
	public  class _MsgX
	{
		static public string Msg_ofAddresses(
			string prog
			,
			string args
			,
			string dir
			,
			CancellationToken cancel

			, int? life = null
			, int? minimum4usr2close = null
			, int? extended4usr2close = null
			, int? waitAftKilling = null

		)
		{
			return os.proc_.finished._result.data._MsgX.Msg(
				timed_.cancelable_.ended.Result.Singleton.ofAddress(
					prog,args,dir,cancel
					,
					life,
					minimum4usr2close
					,
					extended4usr2close
					,
					waitAftKilling
				)
			);
		}
	}
}
