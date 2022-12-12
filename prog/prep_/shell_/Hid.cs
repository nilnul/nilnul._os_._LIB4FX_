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


	public class Hid : Shell
	{
		public Hid(Hid nonShell):base(nonShell)
		{

		}

		public Hid(Shell nonShell):base( nonShell )
		{
			nonShell.info.WindowStyle = ProcessWindowStyle.Hidden;

		}
	

		public Hid(ProcessStartInfo val) : this( new Shell( val ))
		{
		}
		public Hid(PrepI prep) : this(new Shell(prep))
		{
		}

		public Hid(PrepA prep) : this((PrepI)prep)
		{
		}

		public Hid():this(new ProcessStartInfo())
		{
		}

		public Hid(string cmd, string arg = null, string dir = null) : this(
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

		public Hid(string cmd, string arg, ShieldI dir) : this(cmd, arg, dir.ToString())
		{
		}

		public Hid(string cmd, string arg, FolderI dir) : this(cmd, arg, dir.address.en)
		{
		}

		
	}
}
