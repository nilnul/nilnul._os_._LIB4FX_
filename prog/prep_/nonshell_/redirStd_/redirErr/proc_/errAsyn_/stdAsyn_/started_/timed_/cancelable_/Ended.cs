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

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_.timed_.cancelable_
{
	/// <summary>
	/// <see cref="nilnul.win.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_.Timed"/>
	/// </summary>
	public class Ended : Started

	{
	
		public Ended(nilnul.win.prog._run.prep_.nonShell_.redirStd_.RedirErr info, CancellationToken  cancel, int? life=null, int? bye=null
			, int? extended4usr2close = null, int? waitAftKilling = null
		) : base(
			info
		)
		{
				_timeout(cancel, life, bye
					, extended4usr2close,  waitAftKilling
					);

		}

		public Ended(ProcessStartInfo info, CancellationToken  cancel, int? life=null, int? bye=null
			, int? extended4usr2close = null, int? waitAftKilling = null
		) : this(
			new win.prog._run.prep_.nonShell_.redirStd_.RedirErr(info),cancel,life,bye, extended4usr2close,  waitAftKilling
		)
		{
	}

		public Ended(PrepI info, CancellationToken  cancel, int? life=null, int? bye=null, int? extended4usr2close = null, int? waitAftKilling = null) : this(
			info.info,cancel,life,bye, extended4usr2close,  waitAftKilling

		)
		{

		}
		public Ended(PrepA info, CancellationToken  cancel, int? life=null, int? bye=null, int? extended4usr2close = null, int? waitAftKilling = null) : this(
			(PrepI)info,cancel,life,bye, extended4usr2close,  waitAftKilling
		)
		{

		}

		public Ended(string cmd, string arg , string dir 
			,
			CancellationToken cancel
			,
	int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
) :
	this(
	new win.prog._run.prep_.nonShell_.RedirStd(cmd, arg, dir), cancel, life
	, bye
, extended4usr2close, waitAftKilling

)
		{
		}

		public Ended(string cmd, string arg, ShieldI dir
			,
			CancellationToken cancel
			,
			int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
) :
				this(
			new win.prog._run.prep_.nonShell_.RedirStd(cmd, arg, dir), cancel, life
			, bye
, extended4usr2close, waitAftKilling

		)

		{
		}

		public Ended(
			string cmd, string arg, FolderI dir
			,
			CancellationToken cancel
			,
			int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
) :
				this(
			new win.prog._run.prep_.nonShell_.RedirStd(cmd, arg, dir),cancel, life
			, bye
, extended4usr2close, waitAftKilling

		)
		{
		}

	
		private  void _timeout(CancellationToken  cancel=default,  int? life = null, int? bye = null
			,int? extended4usr2close=null, int? waitAftKilling=null
		)
		{
			//this.cancel = cancel;
			 os.proc_.started_.deadlined.end_._OnCancelX.Vod(boxed, cancel, life, bye,waitAftKilling);
			//_task= started.act_.die.traceXpn.kill._DelayX.Task(boxed,cancel, life, bye);

			//var cancelSrc = new CancellationTokenSource();

			//var task = started.act_.die.traceXpn.kill._DelayX.Task(boxed, cancelSrc.Token, life, bye); 
			//boxed.WaitForExit(); 
			//cancelSrc.Cancel();


		}

		/// <summary>
		/// must be called after <see cref="_end"/> has been called
		/// </summary>
		/// <returns></returns>
		public os.proc_.finished._result.CodMsgErr result()
		{
			return new os.proc_.finished._result.CodMsgErr(boxed.ExitCode, base.std, base.err);
		}


	}
}
