using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;




namespace nilnul.os.prog.prep_.nonshell_.nonwin_.redirStd_.redirErr_
{
	public class Min : RedirErr
	{
		public Min(Min info) : base(
			(info)
		)
		{
		}

		public Min(RedirErr info) : base(
			(info)
		)
		{
			info.info.WindowStyle = ProcessWindowStyle.Minimized;
		}





		public Min(RedirStd val) : this(new RedirErr(val))
		{
		}

	


		public Min(Nonshell val) : this(new RedirStd(val))
		{
		}

		public Min(PrepI prep) : this(new Nonshell(prep))
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
