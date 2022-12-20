using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.nonshell_.nonwin_.redirStd_.redirErr.proc_.errAsyn_.started_.stdSyn_.exit_.abort_.onDue0cancel.result
{
	public class Msg
		
	{
		public string ofAddress(string cmd, string arg, string dir, int? life, CancellationToken cancel, int? bye = null
, int? waitAftKill = null
)
		{
			return nilnul.os.proc_.finished._result.data._MsgX.Msg(
				Result.Singleton.ofAddress(cmd,arg,dir,life,  cancel,bye,waitAftKill)
			);

		}
		public string trimmed_ofAddress(string cmd, string arg, string dir, int? life, CancellationToken cancel, int? bye = null
, int? waitAftKill = null
)
		{
			return ofAddress(
				cmd,arg,dir,life,  cancel,bye,waitAftKill
			)?.Trim();

		}


		static public Msg Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Msg>.Instance;
			}
		}

	}
}
