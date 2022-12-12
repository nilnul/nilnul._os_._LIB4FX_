using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.shell_.min.proc_.started_
{
	public class Quit : Started
	{

		public Quit(prep_.shell_.Min info) : base(
				(info)
			)
		{
			boxed.WaitForExit();
		}



		public Quit(prep_.Shell val) : this(new prep_.shell_.Min(val))
		{
		}
		public Quit(PrepI prep) : this(new prep_.Shell(prep))
		{
		}
		public Quit(PrepA prep) : this((PrepI)(prep))
		{
		}

		public Quit(ProcessStartInfo val) : this(new Prep(val))
		{
		}



		public Quit(string cmd, string arg = null, string dir = null) :
			this(
			new Prep(cmd, arg, dir)
		)
		{
		}

		public Quit(string cmd, string arg, ShieldI dir) :
				this(
			new Prep(cmd, arg, dir)
		)

		{
		}

		public Quit(string cmd, string arg, FolderI dir) :
				this(
			new Prep(cmd, arg, dir)
		)


		{
		}

		public int cod
		{
			get
			{
			return this.boxed.ExitCode;

			}

		}



	}
}
