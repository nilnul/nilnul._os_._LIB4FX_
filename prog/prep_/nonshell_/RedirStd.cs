using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;

namespace nilnul.os.prog.prep_.nonshell_
{
	

	public class RedirStd : Nonshell
	{
		public RedirStd(RedirStd nonShell):base(nonShell)
		{

		}

		public RedirStd(Nonshell nonShell):base( nonShell )
		{
			 nonShell.info.RedirectStandardOutput = true;

			nonShell.info.StandardOutputEncoding = System.Text.Encoding.UTF8;
#pragma warning without this line, chinese char in dir name is messy when running git command using shell.




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
