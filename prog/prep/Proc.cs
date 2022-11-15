using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;
using nilnul.win.prog._run;

namespace nilnul.os.prog.prep
{
	/// <summary>
	/// wrapping of a proc. the boxed proc may have varied state; so this can be regarded as a builder design pattern.
	/// </summary>
	public  class Proc
		:
		ProcA
	{
		public Proc(ProcessStartInfo val) : base(val)
		{
		}
		public Proc(Proc val) : base(val.boxed)
		{
		}

		public Proc(Process proc):base(proc)
		{

		}

		public Proc(ProcI proc):this(proc.process)
		{

		}

		public Proc(PrepI prep) : base(prep)
		{
		}
		public Proc(PrepA prep) : base(prep)
		{
		}

		public Proc(string cmd, string arg = null, string dir = null) : base(cmd, arg, dir)
		{
		}

		public Proc(string cmd, string arg, ShieldI dir) : base(cmd, arg, dir)
		{
		}

		public Proc(string cmd, string arg, FolderI dir) : base(cmd, arg, dir)
		{
		}
	}




}
