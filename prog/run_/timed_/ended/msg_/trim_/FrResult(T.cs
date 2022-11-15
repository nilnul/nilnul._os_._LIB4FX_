using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;
using nilnul.win.proc_.started_.timeout_.end.result.msg_;

namespace nilnul.win.proc_.started_.timeout_.end.result.msg.trim_
{
	public class FrResult<TResult> : end.msg.trim_.FrMsg<
		result.msg_.FrResult<TResult>
	>
		where TResult : ResultI
	{
		public FrResult(msg_.FrResult<TResult> msg) : base(msg)
		{
		}
	}
}
