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

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_.timed_
{
	public class Ended
		: Timed
	{
		private CancellationTokenSource _cancelSrc;

		public CancellationTokenSource cancelSrc
		{
			get { return _cancelSrc; }
			set { _cancelSrc = value; }
		}



		public Ended(nilnul.win.prog.prep_.nonshell_.redirStd_.RedirErr info, CancellationTokenSource cancelSrc, int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null) : base(


				info, cancelSrc.Token, life, bye
			, extended4usr2close, waitAftKilling


		)
		{
			_cancelSrc = cancelSrc;
			_end();
		}
		public Ended(nilnul.win.prog._run.prep_.nonShell_.redirStd_.RedirErr info, CancellationTokenSource cancelSrc, int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null) : base(


				info, cancelSrc.Token, life, bye, extended4usr2close, waitAftKilling


		)
		{
			_cancelSrc = cancelSrc;
			_end();
		}

		public Ended(nilnul.win.prog.prep_.nonshell_.redirStd_.RedirErr info, int? life = null, int? bye = null
			, int? extended4usr2close = null, int? waitAftKilling = null
			) : this(


				info, new CancellationTokenSource(), life, bye, extended4usr2close, waitAftKilling


		)
		{
		}
		public Ended(nilnul.win.prog._run.prep_.nonShell_.redirStd_.RedirErr info, int? life = null, int? bye = null
			, int? extended4usr2close = null, int? waitAftKilling = null) : this(


				info, new CancellationTokenSource(), life, bye, extended4usr2close, waitAftKilling


		)
		{
		}

		public Ended(nilnul.win.prog.prep_.nonshell_.RedirStd info
			,
			int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
		) : this(
			new win.prog.prep_.nonshell_.redirStd_.RedirErr(info)

			,
			life, bye, extended4usr2close, waitAftKilling

		)
		{
		}
		public Ended(nilnul.win.prog._run.prep_.nonShell_.RedirStd info
			,
			int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
		) : this(
			new win.prog._run.prep_.nonShell_.redirStd_.RedirErr(info)

			,
			life, bye
			, extended4usr2close, waitAftKilling

		)
		{
		}


		public Ended(win.prog.prep_.Nonshell val
			,
			int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
		) : this(
			new win.prog.prep_.nonshell_.RedirStd(val)
			, life
			, bye
			, extended4usr2close, waitAftKilling
			)

		{
		}

		public Ended(win.prog._run.prep_.NonShell val
			,
			int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
		) : this(
			new win.prog._run.prep_.nonShell_.RedirStd(val)
			, life
			, bye, extended4usr2close, waitAftKilling
			)

		{
		}

		public Ended(ProcessStartInfo val
				,
			int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null

			) : this(
			new win.prog._run.prep_.NonShell(val)
			, life
			, bye, extended4usr2close, waitAftKilling
		)
		{
		}

		public Ended(win.prog._run.PrepI val
			,
			int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
		)
			:
		this(
			new win.prog._run.prep_.NonShell(val)
			, life
			, bye, extended4usr2close, waitAftKilling
		)
		{
		}
		public Ended(win.prog.PrepI val
			,
			int? life = null, int? bye = null
			, int? extended4usr2close = null, int? waitAftKilling = null
		)
			:
		this(
			new win.prog.prep_.Nonshell(val)
			, life
			, bye, extended4usr2close, waitAftKilling
		)
		{
		}


		public Ended(
			win.prog.PrepA val
			,
			int? life = null
			,
			int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
		) : this(
			(win.prog.PrepI)(val)
			, life
			, bye
, extended4usr2close, waitAftKilling

			)
		{
		}


		public Ended(string cmd, string arg = null, string dir = null,
			int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
) :
			this(
			new win.prog._run.prep_.nonShell_.RedirStd(cmd, arg, dir), life
			, bye
, extended4usr2close, waitAftKilling

		)
		{
		}

		public Ended(string cmd, string arg, ShieldI dir,
			int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
) :
				this(
			new win.prog._run.prep_.nonShell_.RedirStd(cmd, arg, dir), life
			, bye
, extended4usr2close, waitAftKilling

		)

		{
		}

		public Ended(string cmd, string arg, FolderI dir,
			int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
) :
				this(
			new win.prog._run.prep_.nonShell_.RedirStd(cmd, arg, dir), life
			, bye
, extended4usr2close, waitAftKilling

		)
		{
		}




		/// <summary>
		/// 
		/// </summary>
		/// <exception cref="Win32">
		///  waiting settings not found
		/// </exception>
		/// <exception cref="nilnul.os.proc_.started_.waited_.xpn_.TimeoutException">
		///  killed, waited for some time, but not ended
		/// </exception>
		private void _end()
		{
			base.task.Wait(); // the task might be faulty, and thence here thows an xpn;

			_cancelSrc.Dispose();
			//return new win.prog._run.Result(boxed.ExitCode, r, this.err);

		}

		/// <summary>
		/// must be called after <see cref="_end"/> has been called
		/// </summary>
		/// <returns></returns>
		public os.proc_.finished._result.CodMsgErr result()
		{
			return new os.proc_.finished._result.CodMsgErr(boxed.ExitCode, base.std, base.err);
		}

		public void cancel() {
			cancelSrc.Cancel();
		}
		public static Ended InSeconds(ProcessStartInfo timeout, int? life = null, int? bye = null
			, int? extended4usr2close = null, int? waitAftKilling = null
		)
		{
			return new Ended(
				timeout
				,
				life == null ? (int?)null : life.Value * 1000
				,
				bye == null ? (int?)null : bye.Value * 1000
				,
				extended4usr2close == null?(int?)null : extended4usr2close.Value * 1000
				,
				waitAftKilling == null ? (int?)null : waitAftKilling.Value * 1000
			);
		}
	}
}
