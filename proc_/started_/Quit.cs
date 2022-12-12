using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;
using nilnul.os.prog;

namespace nilnul.os.proc_.started_
{
	public class Quit : Started
	{

		public Quit(os.prog.PrepI info) : base(
			(info)
		)
		{
			this.boxed.WaitForExit();
		}
	

		public Quit(Prep val) : this(
			(PrepI)(val)

			)
		{
		}
		
	
		public Quit(PrepA val) : this(
			(PrepI)(val)

			)
		{
		}

		public Quit(ProcessStartInfo val) : this(new os.prog.Prep( val) )
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
