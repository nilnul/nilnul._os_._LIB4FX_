using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;
using nilnul.win.prog._run;
using nilnul.win.prog._run.prep_;
using nilnul.win.prog._run.prep_.nonShell_;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_
{
	public class Min : RedirErr
	{
		public Min(nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_.Min info) : base(
			(info)
		)
		{
		}

		public Min(nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info) : base(
			(info)
		)
		{
			info.info.WindowStyle = ProcessWindowStyle.Minimized;
		}





		public Min(prog.prep_.nonshell_.RedirStd val) : this(new prog.prep_.nonshell_.redirStd_.RedirErr(val))
		{
		}

	


		public Min(prog.prep_.Nonshell val) : this(new prog.prep_.nonshell_.RedirStd(val))
		{
		}

		public Min(PrepI prep) : this(new prog.prep_.Nonshell(prep))
		{
		}
		public Min(PrepA prep) : this((PrepI)(prep))
		{
		}

		public Min(ProcessStartInfo val) : this(new prog.Prep(val))
		{
		}


		public Min(string cmd, string arg = null, string dir = null) : this(
			new prog.Prep(
			cmd, arg, dir
			)
		)
		{
		}

		public Min(string cmd, string arg, ShieldI dir) : this(
			
			cmd, arg, dir.ToString()
			
			)
		{
		}

		public Min(string cmd, string arg, FolderI dir) : this(
			cmd, arg, dir.address.en
			
			)

		{
		}
	}
}
