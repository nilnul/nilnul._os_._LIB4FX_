using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit_.delayed_.onDue0cancel.result
{
	public  class _MsgX
	{
		static public string Msg_ofAddresses(
			string prog
			,
			string args
			,
			string dir
			, int? life 
			,
			CancellationToken cancel
			,
			int? runAftCancel

			, int? minimum4usr2close = null
			, int? waitAftKilling = null

		)
		{
			return os.proc_.finished._result.data._MsgX.Msg(
				Result.Singleton.ofAddress(
					prog,args,dir
					,
					life
					,
					cancel
					,
					runAftCancel
					,
					minimum4usr2close
					,
					waitAftKilling
				)
			);
		}
	}
}
