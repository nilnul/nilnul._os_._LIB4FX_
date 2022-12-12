using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;




namespace nilnul.os.prog.prep_.nonshell_.win
{
	public class Proc :os.Proc
	{

		public Proc(prep_.nonshell_.Win info) : base(
			(info)
		)
		{
		}

		public Proc(prep_.Nonshell val) : this(new prep_.nonshell_.Win(val))
		{
		}
		public Proc(PrepI prep) : this(new prep_.Nonshell(prep))
		{
		}
		public Proc(PrepA prep) : this((PrepI)(prep))
		{
		}

		public Proc(ProcessStartInfo val) : this(new Prep(val))
		{
		}


		public Proc(string cmd, string arg = null, string dir = null) : this(
			new Prep(
			cmd, arg, dir
			)
		)
		{
		}

		public Proc(string cmd, string arg, ShieldI dir) : this(
			
			cmd, arg, dir.ToString()
			
			)
		{
		}

		public Proc(string cmd, string arg, FolderI dir) : this(
			cmd, arg, dir.address.en
			
			)

		{
		}
	}
}
