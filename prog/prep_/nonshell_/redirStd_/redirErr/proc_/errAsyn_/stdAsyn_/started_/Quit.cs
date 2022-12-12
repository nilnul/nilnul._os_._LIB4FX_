using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;


using nilnul.os.proc_.finished._result;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_
{

	[Obsolete(nameof(redirErr.proc_.errAsyn_.started_.stdSyn_.exit)+ " is prefered as some weird issue occurs during output lines lacking line break;")]
	public class Quit
		:
		 Started
	{
		public Quit(RedirErr info) : base(
			(info)
		)
		{
			boxed.WaitForExit();
			//boxed.StandardOutput.BaseStream.Flush(); //cannot mix async with sync
			//boxed.StandardError.BaseStream.Flush();

			//boxed.Close(); //flush output

		}

		public Quit(RedirStd info) : this(
			new RedirErr
			(info)
		)
		{
		}

		public Quit(Nonshell val) : this(
			new RedirStd(val))
		{
		}


		public Quit(PrepI val) : this(
			new Nonshell(val)

			)
		{
		}
		public Quit(PrepA val) : this(
			(PrepI)(val)

			)
		{
		}

		public Quit(Prep val) : this(
			new Nonshell(val)
		)
		{
		}
		public Quit(ProcessStartInfo val) : this(
			new Nonshell(val)
		)
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


		public CodMsgErr result
		{
			get {
				return new CodMsgErr(boxed.ExitCode,this.std, this.err);

			}



		}



	}
}
