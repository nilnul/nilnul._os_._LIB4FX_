using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;

using nilnul.os.prog.prep_.nonshell_.redirStd_;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_
{


	/// <summary>
	/// true if the process should be started without creating a new window to contain it; otherwise, false. The default is false.
	/// This is not the default
	/// </summary>
	public class UiUnattempted : Min
	{
		public UiUnattempted(UiUnattempted nonShell):base(nonShell)
		{
		}
		public UiUnattempted(Min nonShell):base ((nonShell))
		{
			nonShell.info.CreateNoWindow = true;
		}
		public UiUnattempted(RedirStd nonShell):this ( new Min(nonShell))
		{

		}

		public UiUnattempted(PrepI prep) : this(new RedirStd(prep.info))
		{
		}
		public UiUnattempted(PrepA prep) : this((PrepI)prep)
		{
		}
		public UiUnattempted(ProcessStartInfo val) : this( new Prep( val ))
		{
		}


		public UiUnattempted():this(new ProcessStartInfo())
		{
		}

		public UiUnattempted(string cmd, string arg = null, string dir = null) : this(
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

		public UiUnattempted(string cmd, string arg, ShieldI dir) : this(cmd, arg, dir.ToString())
		{
		}

		public UiUnattempted(string cmd, string arg, FolderI dir) : this(cmd, arg, dir.address.en)
		{
		}




	}
}
