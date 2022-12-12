using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.started_.stdSyn_
{
	public class Quit
		: StdSyn

	{
		public Quit(nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info) : base(
				info


		)
		{
			_end();
		}
		public Quit(nilnul.os.prog.prep_.nonshell_.RedirStd info

		) : this(
			new prog.prep_.nonshell_.redirStd_.RedirErr(info)

		)
		{
		}

		public Quit(prog.prep_.Nonshell val

		) : this(
			new prog.prep_.nonshell_.RedirStd(val)

			)

		{
		}


		public Quit(PrepI val

) : this(
			new prog.prep_.Nonshell(val)


			)
		{
		}
		public Quit(PrepA val
		) : this(
			(PrepI)(val)


			)
		{
		}
		public Quit(ProcessStartInfo val


			) : this(
			new prog.prep_.Nonshell(val)

		)
		{
		}


		public Quit(string cmd, string arg = null, string dir = null

) :
			this(
			new prog.Prep(cmd, arg, dir)

		)
		{
		}

		public Quit(string cmd, string arg, ShieldI dir
) :
				this(
			new prog.Prep(cmd, arg, dir)

		)

		{
		}

		public Quit(string cmd, string arg, FolderI dir
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

			//return new nilnul.os.proc_.finished._result.CodMsgErr(boxed.ExitCode, r, this.err);

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
