using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.nonshell_.nonwin_.redirStd_.redirErr.proc_.errAsyn_.started_.stdSyn_
{
	public class Waited
		: StdSyn

	{
		public Waited(RedirErr info) : base(
				info


		)
		{
			_end();
		}
		public Waited(RedirStd info

		) : this(
			new RedirErr(info)

		)
		{
		}

		public Waited(Nonshell val

		) : this(
			new RedirStd(val)

			)

		{
		}


		public Waited(PrepI val

) : this(
			new Nonshell(val)


			)
		{
		}
		public Waited(PrepA val
		) : this(
			(PrepI)(val)


			)
		{
		}
		public Waited(ProcessStartInfo val


			) : this(
			new Nonshell(val)

		)
		{
		}


		public Waited(string cmd, string arg = null, string dir = null

) :
			this(
			new prog.Prep(cmd, arg, dir)

		)
		{
		}

		public Waited(string cmd, string arg, ShieldI dir
) :
				this(
			new prog.Prep(cmd, arg, dir)

		)

		{
		}

		public Waited(string cmd, string arg, FolderI dir
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
