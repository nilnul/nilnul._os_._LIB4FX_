using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.timed_.ended.msg_
{
	public class FrResult<TResult>
		:MsgA

		where TResult:ended.ResultI

	{
		private TResult _boxed;

		public TResult boxed
		{
			get { return _boxed; }
			set { _boxed = value; }
		}

		public FrResult(TResult val) 
		{
			_boxed = val;

		}

		public override string ofAddress(string cmd, string arg, string dir, int? life = null, int? bye = null)
		{
			return nilnul.win.prog._run.result._MsgX.Msg(_boxed.ofAddress(cmd,arg,dir,life,bye));
		}
	}
}
