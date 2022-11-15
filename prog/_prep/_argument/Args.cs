using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog._prep._argument
{
	public class Args : nilnul.obj.Box1<IEnumerable<Arg>>
	{
		public Args(IEnumerable<Arg> val) : base(val)
		{
		}
		public Args(IEnumerable<string> args):this(
			args.Select(x=> new Arg(x) )

			)
		{
		}

		public Args(params string[] val) : this(
			(IEnumerable<string>)val
		)
		{
				
		}


		public override string ToString()
		{
			return string.Join(" ", boxed.Select(a=>a.ToString()));
		}
	}
}
