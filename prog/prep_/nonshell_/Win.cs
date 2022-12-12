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
	

	public class Win : Nonshell
	{
		public Win(Win nonShell):base(nonShell)
		{

		}

		public Win(Nonshell nonShell):base( nonShell )
		{
			nonShell.info.CreateNoWindow = false;




		}

		public Win(ProcessStartInfo val) : this( new Nonshell( val ))
		{
		}
		public Win(PrepI prep) : this(new Nonshell(prep))
		{
		}

		public Win(PrepA prep) : this((PrepI)prep)
		{
		}

		public Win():this(new ProcessStartInfo())
		{
		}

		public Win(string cmd, string arg = null, string dir = null) : this(
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

		public Win(string cmd, string arg, ShieldI dir) : this(cmd, arg, dir.ToString())
		{
		}

		public Win(string cmd, string arg, FolderI dir) : this(cmd, arg, dir.address.en)
		{
		}

		
	}
}
