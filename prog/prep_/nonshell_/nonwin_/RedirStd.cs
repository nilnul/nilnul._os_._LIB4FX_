using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;
using nilnul.os.prog.prep_.shell_;

namespace nilnul.os.prog.prep_.nonshell_.nonwin_
{
	

	public class RedirStd : Nonwin
	{
		public RedirStd(RedirStd nonShell):base(nonShell)
		{

		}

		public RedirStd(Nonwin nonShell):base( nonShell )
		{
			 nonShell.info.RedirectStandardOutput = true;

			nonShell.info.StandardOutputEncoding = System.Text.Encoding.UTF8;
#pragma warning without this line, chinese char in dir name is messy when running git command using shell.

		}
		public RedirStd(Nonshell nonShell):this( new Nonwin( nonShell  ))
		{
		}

		public RedirStd(ProcessStartInfo val) : this( new Nonshell( val ))
		{
		}

		public RedirStd(PrepI prep) : this(new Nonshell(prep))
		{
		}

		public RedirStd(PrepA prep) : this((PrepI)prep)
		{
		}

		public RedirStd():this(new ProcessStartInfo())
		{
		}

		public RedirStd(string cmd, string arg = null, string dir = null) : this(
			new ProcessStartInfo()
			{
				FileName=cmd
				,
				Arguments=arg,
				WorkingDirectory=dir

			}
			)
		{
		}

		public RedirStd(string cmd, string arg, ShieldI dir) : this(cmd, arg, dir.ToString())
		{
		}

		public RedirStd(string cmd, string arg, FolderI dir) : this(cmd, arg, dir.address.en)
		{
		}

		
	}
}
