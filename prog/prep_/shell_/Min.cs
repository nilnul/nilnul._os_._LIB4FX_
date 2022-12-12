using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;

namespace nilnul.os.prog.prep_.shell_
{

	public class Min : Shell
	{
		public Min(Min nonShell):base(nonShell)
		{

		}

		public Min(Shell nonShell):base( nonShell )
		{
			nonShell.info.WindowStyle = ProcessWindowStyle.Minimized;




		}

		public Min(ProcessStartInfo val) : this( new Shell( val ))
		{
		}
		public Min(PrepI prep) : this(new Shell(prep))
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
