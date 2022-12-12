using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;

namespace nilnul.os.prog.prep_.nonshell_.win_
{
	

	public class Min : Win
	{
		public Min(Min nonShell):base(nonShell)
		{

		}
		public Min(Win nonShell):base( nonShell )
		{

		}

		public Min(Nonshell nonShell):base( nonShell )
		{
			nonShell.info.CreateNoWindow = true;

		}

		public Min(ProcessStartInfo val) : this( new Nonshell( val ))
		{
		}
		public Min(PrepI prep) : this(new Nonshell(prep))
		{
		}

		public Min(PrepA prep) : this((PrepI)prep)
		{
		}

		public Min():this(new ProcessStartInfo())
		{
		}

		public Min(string cmd, string arg = null, string dir = null) : this(
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

		public Min(string cmd, string arg, ShieldI dir) : this(cmd, arg, dir.ToString())
		{
		}

		public Min(string cmd, string arg, FolderI dir) : this(cmd, arg, dir.address.en)
		{
		}

		
	}
}
