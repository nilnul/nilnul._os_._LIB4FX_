using nilnul.win.prog._run;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.win.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_;
using nilnul.fs;
using nilnul.fs.address_;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_.timed_
{
	/// <summary>
	/// </summary>
	public class Ended_handleSomeXpn : Started
	{

		public Ended_handleSomeXpn(nilnul.win.prog._run.prep_.nonShell_.redirStd_.RedirErr info, int? life = null, int? bye = null) : base(
			info
		)
		{
			_waitout(life, bye);
		}

		public Ended_handleSomeXpn(ProcessStartInfo info, int? life = null, int? bye = null) : this(
			new win.prog._run.prep_.nonShell_.redirStd_.RedirErr(info), life, bye
		)
		{
		}

		public Ended_handleSomeXpn(PrepI info, int? life = null, int? bye = null) : this(
			info.info, life, bye
		)
		{

		}
		public Ended_handleSomeXpn(PrepA info, int? life = null, int? bye = null) : this(
			(PrepI)info, life, bye
		)
		{

		}


		public Ended_handleSomeXpn(string cmd, string arg = null, string dir = null,
			int? life = null, int? bye = null
) :
			this(
			new win.prog._run.prep_.nonShell_.RedirStd(cmd, arg, dir), life
			, bye

		)
		{
		}

		public Ended_handleSomeXpn(string cmd, string arg, ShieldI dir,
			int? life = null, int? bye = null
) :
				this(
			new win.prog._run.prep_.nonShell_.RedirStd(cmd, arg, dir), life
			, bye

		)

		{
		}

		public Ended_handleSomeXpn(string cmd, string arg, FolderI dir,
			int? life = null, int? bye = null
) :
				this(
			new win.prog._run.prep_.nonShell_.RedirStd(cmd, arg, dir), life
			, bye

		)
		{
		}



		//private Task _task;

		//public Task task
		//{
		//	get { return _task; }
		//	set { _task = value; }
		//}

		//private CancellationToken _cancel;

		//public CancellationToken cancel
		//{
		//	get { return _cancel; }
		//	set { _cancel = value; }
		//}

		//public void cancel() {

		//}
		private void _waitout(int? life = null, int? bye = null)
		{
			//this.cancel = cancel;
			os.proc_.started.end_.ulti.defer._WaitOutX.Act(boxed, life, bye);
			//_task= started.act_.die.traceXpn.kill._DelayX.Task(boxed,cancel, life, bye);

			//var cancelSrc = new CancellationTokenSource();

			//var task = started.act_.die.traceXpn.kill._DelayX.Task(boxed, cancelSrc.Token, life, bye); 
			//boxed.WaitForExit(); 
			//cancelSrc.Cancel();


		}

		public os.proc_.finished._result.CodMsgErr result()
		{
			return new os.proc_.finished._result.CodMsgErr(boxed.ExitCode, base.std, base.err);
		}

		public static Ended_handleSomeXpn OfPeriodsEachInSeconds(ProcessStartInfo timeout, int? life = null, int? bye = null)
		{
			return new Ended_handleSomeXpn(
				timeout
				,
				life == null ? (int?)null : life.Value * 1000
				,
				bye == null ? (int?)null : bye.Value * 1000
			);
		}

	}
}
