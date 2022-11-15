using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;
using nilnul.win.prog._run;
using nilnul.win.prog._run.prep_;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_.min.proc_.errAsyn_.started_.stdSyn_
{
	public class Ended
		: StdSyn

	{
		public Ended(nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info) : base(
				info


		)
		{
			_end();
		}
		public Ended(nilnul.os.prog.prep_.nonshell_.RedirStd info

		) : this(
			new prog.prep_.nonshell_.redirStd_.RedirErr(info)

		)
		{
		}

		public Ended(prog.prep_.Nonshell val

		) : this(
			new prog.prep_.nonshell_.RedirStd(val)

			)

		{
		}


		public Ended(PrepI val

) : this(
			new prog.prep_.Nonshell(val)


			)
		{
		}
		public Ended(PrepA val
		) : this(
			(PrepI)(val)


			)
		{
		}
		public Ended(ProcessStartInfo val


			) : this(
			new prog.prep_.Nonshell(val)

		)
		{
		}


		public Ended(string cmd, string arg = null, string dir = null

) :
			this(
			new prog.Prep(cmd, arg, dir)

		)
		{
		}

		public Ended(string cmd, string arg, ShieldI dir
) :
				this(
			new prog.Prep(cmd, arg, dir)

		)

		{
		}

		public Ended(string cmd, string arg, FolderI dir
) :
				this(
			new prog.Prep(cmd, arg, dir)

		)
		{
		}




		private void _end()
		{

			// To avoid deadlocks, always read the output stream first and then wait.  
			boxed.WaitForExit();

			//return new win.prog._run.Result(boxed.ExitCode, r, this.err);

		}
		public os.proc_.finished._result.CodMsgErr result
		{

			get
			{
				return new os.proc_.finished._result.CodMsgErr(boxed.ExitCode, base.msg, base.err);

			}


		}


	}
}
