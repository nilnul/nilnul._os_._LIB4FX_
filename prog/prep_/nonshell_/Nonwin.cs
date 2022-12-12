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
	

	public class Nonwin : Nonshell
	{
		public Nonwin(Nonwin nonShell):base(nonShell)
		{

		}

		public Nonwin(Nonshell nonShell):base( nonShell )
		{
			nonShell.info.CreateNoWindow = true;




		}

		public Nonwin(ProcessStartInfo val) : this( new Nonshell( val ))
		{
		}
		public Nonwin(PrepI prep) : this(new Nonshell(prep))
		{
		}

		public Nonwin(PrepA prep) : this((PrepI)prep)
		{
		}

		public Nonwin():this(new ProcessStartInfo())
		{
		}

		public Nonwin(string cmd, string arg = null, string dir = null) : this(
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

		public Nonwin(string cmd, string arg, ShieldI dir) : this(cmd, arg, dir.ToString())
		{
		}

		public Nonwin(string cmd, string arg, FolderI dir) : this(cmd, arg, dir.address.en)
		{
		}

		
	}
}
