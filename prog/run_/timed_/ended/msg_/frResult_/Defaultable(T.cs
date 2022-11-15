using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;

namespace nilnul.os.prog.run_.timed_.ended.msg_.frResult_
{
	public class Defaultable<TResult> : FrResult<TResult>
		where TResult : ended.ResultI, new()
	{
		public Defaultable() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TResult>.Instance
				)
		{
		}


		static public Defaultable<TResult> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Defaultable<TResult>>.Instance;
			}
		}


	}
}
