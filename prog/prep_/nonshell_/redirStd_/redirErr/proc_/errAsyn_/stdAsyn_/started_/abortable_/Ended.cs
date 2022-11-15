using nilnul.win.prog._run;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.win.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_;
using nilnul.fs.address_;
using nilnul.fs;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_.abortable_
{
	/// <summary>
	/// abort the process: if it's running, kill it;
	/// </summary>
	public class Ended : started_.Abortable

	{

	


		public Ended(
			nilnul.win.prog._run.prep_.nonShell_.redirStd_.RedirErr info,   int? minimum4usr2close=null
			,  int? waitAftKilling = null

			) : base(
			info,minimum4usr2close,waitAftKilling
		)
		{
			base._end();


		}


		public Ended(ProcessStartInfo info,  int? minimum4usr2close=null
			,  int? waitAftKilling = null

			) : this(
			new win.prog._run.prep_.nonShell_.redirStd_.RedirErr(info), minimum4usr2close,  waitAftKilling
		)
		{
	}

		public Ended(PrepI info,   int? minimum4usr2close= null,  int? waitAftKilling = null
) : this(
			info.info, minimum4usr2close,  waitAftKilling
		)
		{

		}
		public Ended(PrepA info
			,   int? minimum4usr2close= null,  int? waitAftKilling = null
) : this(
			(PrepI)info, minimum4usr2close,  waitAftKilling
		)
		{

		}



		public Ended(string cmd, string arg = null, string dir = null			,   int? minimum4usr2close= null,  int? waitAftKilling = null
) :
			this(
			new win.prog._run.prep_.nonShell_.RedirStd(cmd, arg, dir)
				,minimum4usr2close
				,
			waitAftKilling
		)
		{
		}

		public Ended(string cmd, string arg, ShieldI dir			,   int? minimum4usr2close= null,  int? waitAftKilling = null
) :
				this(
			new win.prog._run.prep_.nonShell_.RedirStd(cmd, arg, dir)
				,minimum4usr2close
				,
			waitAftKilling
		)

		{
		}

		public Ended(string cmd, string arg, FolderI dir			,   int? minimum4usr2close= null,  int? waitAftKilling = null
) :
				this(
			new win.prog._run.prep_.nonShell_.RedirStd(cmd, arg, dir)
				,minimum4usr2close
				,
			waitAftKilling
		)


		{
		}
		public nilnul.win.prog._run.Result result
		{
			get
			{
				return new nilnul.win.prog._run.Result(boxed.ExitCode, std, this.err);

			}



		}


	}
}
