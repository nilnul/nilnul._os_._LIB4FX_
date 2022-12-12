using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;

namespace nilnul.os.prog.prep_
{
	
	/// <summary>
	/// a builder
	/// </summary>
	public class Nonshell : Prep
	{
		public Nonshell(Nonshell nonShell):base(nonShell)
		{

		}

		public Nonshell(ProcessStartInfo val) : base(val)
		{
			val.UseShellExecute = false;        //The default is true on .NET Framework apps and false on .NET Core apps.
			val.CreateNoWindow = true; //the default is false; if false, we have too much windows popping out;
		//	val.WindowStyle = ProcessWindowStyle.Hidden;
			val.WindowStyle = ProcessWindowStyle.Minimized;
		}

		public Nonshell():this(new ProcessStartInfo())
		{
		}

		public Nonshell(string cmd, string arg = null, string dir = null) : this(
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

		public Nonshell(string cmd, string arg, ShieldI dir) : this(cmd, arg, dir.ToString())
		{
		}

		public Nonshell(string cmd, string arg, FolderI dir) : this(cmd, arg, dir.address.en)
		{
		}

		public Nonshell(PrepI prep):this( prep.info)
		{

		}
		protected Nonshell(PrepA prep) : this((PrepI)prep)
		{
		}

	}
}
