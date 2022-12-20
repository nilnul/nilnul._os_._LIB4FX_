using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;




namespace nilnul.os.prog.prep_.nonshell_.nonwin_.redirStd_.redirErr
{
	public class Proc :os.Proc
	{

		public Proc(RedirErr info) : base(
			(info)
		)
		{
		}

		public Proc(RedirStd val) : this(new RedirErr(val))
		{
		}


		public Proc(Nonwin val) : this(new RedirStd(val))
		{
		}
		public Proc(Nonshell val) : this(new Nonwin(val))
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
