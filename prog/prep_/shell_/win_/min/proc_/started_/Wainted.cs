using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started_
{
	public class Waited : Started
	{

		public Waited(prep_.shell_.win_.Min info) : base(
				(info)
			)
		{
			boxed.WaitForExit();
		}
		public Waited(prep_.shell_.Win info) : this(new Min(info)
			)
		{
		}



		public Waited(prep_.Shell val) : this(new prep_.shell_.Win(val))
		{
		}
		public Waited(PrepI prep) : this(new prep_.Shell(prep))
		{
		}
		public Waited(PrepA prep) : this((PrepI)(prep))
		{
		}

		public Waited(ProcessStartInfo val) : this(new Prep(val))
		{
		}



		public Waited(string cmd, string arg = null, string dir = null) :
			this(
			new Prep(cmd, arg, dir)
		)
		{
		}

		public Waited(string cmd, string arg, ShieldI dir) :
				this(
			new Prep(cmd, arg, dir)
		)

		{
		}

		public Waited(string cmd, string arg, FolderI dir) :
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
