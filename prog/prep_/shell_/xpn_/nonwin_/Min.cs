using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;

namespace nilnul.os.prog.prep_.shell_.nonwin_
{

	[Obsolete(nameof(shell_.xpn_.UiIsAlwaysCreated4WinException))]

	public class Min : Nonwin
	{
		public Min(Min nonShell):base(nonShell)
		{

		}

		public Min(Nonwin nonShell):base( nonShell )
		{
			nonShell.info.WindowStyle = ProcessWindowStyle.Minimized;

		}
		public Min(Shell nonShell):this( new Nonwin( nonShell ))
		{

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
