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


	[Obsolete(nameof(xpn_.UiIsAlwaysCreated4WinException))]
	public class Nonwin : Shell
		,
		prep_.shell_.IXpn ///<see cref="shell_.xpn_.UiIsAlwaysCreated4WinException"/>
	{
		public Nonwin(Nonwin nonShell):base(nonShell)
		{

		}

		public Nonwin(Shell nonShell):base( nonShell )
		{
			nonShell.info.WindowStyle = ProcessWindowStyle.Minimized;




		}

		public Nonwin(PrepI prep) : this(new Shell(prep))
		{
		}

		public Nonwin(PrepA prep) : this((PrepI)prep)
		{
		}

		public Nonwin(ProcessStartInfo val) : this( new Nonshell( val ))
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
