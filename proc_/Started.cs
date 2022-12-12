using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;
using nilnul.os.prog;
//
//

namespace nilnul.os.proc_
{
	[Obsolete(nameof(os.prog.prep.proc_.Started))]
	public class Started : Proc
	{

		public Started(Started prep) : base(prep)
		{
		}

		public Started(prog.PrepI prep) : base(prep)
		{
			boxed.Start();

		}

		//public Started(PrepI prep) : this(new os.prog.Prep( prep ))
		//{

		//}


		public Started(Prep val) : this((PrepI)val)
		{
		}
		public Started(PrepA val) : this((PrepI)val)
		{
		}


		public Started(ProcessStartInfo val) : this(new os.prog.Prep( val ))
		{
		}


		public Started(string cmd, string arg = null, string dir = null) : this(
			new os.prog.Prep(
			cmd, arg, dir
			)
		)
		{
		}

		public Started(string cmd, string arg, ShieldI dir) : this(
			new Prep(
			cmd, arg, dir
			)
			)
		{
		}

		public Started(string cmd, string arg, FolderI dir) : this(
			new Prep(
			cmd, arg, dir
			)
			)

		{
		}
	}
}
