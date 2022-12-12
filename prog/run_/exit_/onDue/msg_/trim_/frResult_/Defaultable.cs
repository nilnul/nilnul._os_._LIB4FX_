using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;

namespace nilnul.os.prog.run_.exit_.onDue.msg_.trim_.frResult_
{
	public class Defaultable<TResult>
		: FrResult<TResult>
		where TResult : ResultI, new()
	{
		public Defaultable() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TResult>.Instance
				)
		{
		}
	}
}
