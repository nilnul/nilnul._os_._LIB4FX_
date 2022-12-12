using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.nonshell_.win.proc_.started_
{
	public class Ended : Started
	{

		public Ended(prep_.nonshell_.Win info) : base(
				(info)
			)
		{
			boxed.WaitForExit();
		}



		public Ended(prep_.Nonshell val) : this(new prep_.nonshell_.Win(val))
		{
		}
		public Ended(PrepI prep) : this(new prep_.Nonshell(prep))
		{
		}
		public Ended(PrepA prep) : this((PrepI)(prep))
		{
		}

		public Ended(ProcessStartInfo val) : this(new Prep(val))
		{
		}



		public Ended(string cmd, string arg = null, string dir = null) :
			this(
			new Prep(cmd, arg, dir)
		)
		{
		}

		public Ended(string cmd, string arg, ShieldI dir) :
				this(
			new Prep(cmd, arg, dir)
		)

		{
		}

		public Ended(string cmd, string arg, FolderI dir) :
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
