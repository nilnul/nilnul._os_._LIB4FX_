using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;

namespace nilnul.os.prog.run_.exit_.onDue.msg_.trim_
{
	public class FrResult<TResult> : exit_.onDue.msg_.trim_.FrMsg<
		onDue.msg_.FrResult<TResult>
	>
		where TResult : ResultI
	{
		public FrResult(msg_.FrResult<TResult> msg) : base(msg)
		{
		}

		public FrResult(TResult instance):this(
			new msg_.FrResult<TResult>(instance)
		)
		{
		}
	}
}
