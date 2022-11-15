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

namespace nilnul.os.prog.prep_.nonshell_.redirStd_
{
	public class RedirErr : RedirStd
	{
		public RedirErr(nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info) : base(
			(info)
		)
		{
		}

	



		public RedirErr(prog.prep_.nonshell_.RedirStd val) : base(val)
		{
			val.info.RedirectStandardError =true;
		}

	


		public RedirErr(prog.prep_.Nonshell val) : this(new prog.prep_.nonshell_.RedirStd(val))
		{
		}

		public RedirErr(PrepI prep) : this(new prog.prep_.Nonshell(prep))
		{
		}
		public RedirErr(PrepA prep) : this((PrepI)(prep))
		{
		}

		public RedirErr(ProcessStartInfo val) : this(new prog.Prep(val))
		{
		}


		public RedirErr(string cmd, string arg = null, string dir = null) : this(
			new prog.Prep(
			cmd, arg, dir
			)
		)
		{
		}

		public RedirErr(string cmd, string arg, ShieldI dir) : this(
			
			cmd, arg, dir.ToString()
			
			)
		{
		}

		public RedirErr(string cmd, string arg, FolderI dir) : this(
			cmd, arg, dir.address.en
			
			)

		{
		}
	}
}
