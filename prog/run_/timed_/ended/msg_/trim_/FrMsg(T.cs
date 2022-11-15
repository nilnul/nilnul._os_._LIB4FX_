using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;

namespace nilnul.os.prog.run_.timed_.ended.msg_.trim_
{
	public class FrMsg<TMsg> : TrimA
		where TMsg: MsgI
	{
		private TMsg _boxed;

		public TMsg boxed
		{
			get { return _boxed; }
			set { _boxed = value; }
		}

		public FrMsg(TMsg msg)
		{
			_boxed = msg;
		}

		public override string ofAddress(string cmd, string arg=null, string dir=null, int? life = null, int? bye = null)
		{
			return boxed.ofAddress(cmd, arg, dir,life,bye)?.Trim();
		}


	}
}
