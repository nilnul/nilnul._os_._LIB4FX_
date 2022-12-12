using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit_.onDue.result_.stdSyn
{
	[Obsolete(nameof(result_.StdSyn) + " is preferred as this brings about a weird issue: the line breaks are gone even if we add line breaks manually;", true)]

	public class _MsgX
	{
		static public string Msg_ofAddresses(
			string prog
			,
			string args
			,
			string dir

			, int? life = null
			, int? minimum4usr2close = null
			, int? waitAftKilling = null

		)
		{
			return os.proc_.finished._result.data._MsgX.Msg(
				result_.StdSyn.Singleton.ofAddress(
					prog,args
					,dir
					,
					life,
					minimum4usr2close
					,
					waitAftKilling
				)
			);
		}
	}
}
