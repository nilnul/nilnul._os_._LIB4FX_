using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;
using nilnul.win.prog._run;
using nilnul.win.prog._run.prep_;
using nilnul.win.proc_.nonshell_.redirStd_.redirErr_.errAsyn_.stdAsyn_.started_;
using nilnul.os.proc_.finished._result;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_
{

	public class Ended
		:
		 Started
	{
		public Ended(RedirErr info) : base(
			(info)
		)
		{
			boxed.WaitForExit();
			//boxed.StandardOutput.BaseStream.Flush(); //cannot mix async with sync
			//boxed.StandardError.BaseStream.Flush();

			//boxed.Close(); //flush output

		}

		public Ended(RedirStd info) : this(
			new RedirErr
			(info)
		)
		{
		}

		public Ended(Nonshell val) : this(
			new RedirStd(val))
		{
		}


		public Ended(PrepI val) : this(
			new Nonshell(val)

			)
		{
		}
		public Ended(PrepA val) : this(
			(PrepI)(val)

			)
		{
		}

		public Ended(Prep val) : this(
			new Nonshell(val)
		)
		{
		}
		public Ended(ProcessStartInfo val) : this(
			new Nonshell(val)
		)
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


		public CodMsgErr result
		{
			get {
				return new CodMsgErr(boxed.ExitCode,this.std, this.err);

			}



		}



	}
}
