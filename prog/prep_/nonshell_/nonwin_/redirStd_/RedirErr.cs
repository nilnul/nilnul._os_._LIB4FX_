using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;




namespace nilnul.os.prog.prep_.nonshell_.nonwin_.redirStd_
{
	public class RedirErr : RedirStd
	{
		public RedirErr(RedirErr info) : base(
			(info)
		)
		{
		}

	



		public RedirErr(RedirStd val) : base(val)
		{
			val.info.RedirectStandardError =true;
			val.info.StandardErrorEncoding = System.Text.Encoding.UTF8;
#pragma warning without this line, chinese char in dir name is messy when running git command using shell.


		}



		public RedirErr(Nonwin val) : this(new RedirStd(val))
		{
		}

		public RedirErr(Nonshell val) : this(new Nonwin(val))
		{
		}

		public RedirErr(PrepI prep) : this(new Nonshell(prep))
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
