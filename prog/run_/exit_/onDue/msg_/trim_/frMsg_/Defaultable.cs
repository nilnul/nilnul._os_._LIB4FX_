using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;

namespace nilnul.os.prog.run_.exit_.onDue.msg_.trim_.frMsg_
{
	public class Defaultable<TMsg> : FrMsg<TMsg>
		where TMsg : MsgI, new()
	{
		public Defaultable() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TMsg>.Instance
				)
		{
		}
	}
}
