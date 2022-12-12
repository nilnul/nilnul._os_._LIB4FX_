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
	public class Shell : Prep
	{
		public Shell(Shell nonShell):base(nonShell)
		{

		}

		public Shell(ProcessStartInfo val) : base(val)
		{
			val.UseShellExecute = true;        //The default is true on .NET Framework apps and false on .NET Core apps.
			//val.CreateNoWindow = true; //the default is false; if false, we have too much windows popping out;
		//	val.WindowStyle = ProcessWindowStyle.Hidden;
			//val.WindowStyle = ProcessWindowStyle.Minimized;
		}

		public Shell():this(new ProcessStartInfo())
		{
		}

		public Shell(string cmd, string arg = null, string dir = null) : this(
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

		public Shell(string cmd, string arg, ShieldI dir) : this(cmd, arg, dir.ToString())
		{
		}

		public Shell(string cmd, string arg, FolderI dir) : this(cmd, arg, dir.address.en)
		{
		}

		public Shell(PrepI prep):this( prep.info)
		{

		}
		protected Shell(PrepA prep) : this((PrepI)prep)
		{
		}

	}
}
