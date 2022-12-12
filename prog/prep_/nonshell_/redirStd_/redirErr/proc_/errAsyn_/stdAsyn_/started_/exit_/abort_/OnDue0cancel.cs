
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_.exit_.abort_
{
	/// <summary>
	/// <see cref="nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_.Timed"/>
	/// </summary>
	public class OnDue0cancel : Started

	{
	
		public OnDue0cancel(nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info, CancellationToken  cancel, int? life=null, int? bye=null
			, int? extended4usr2close = null, int? waitAftKilling = null
		) : base(
			info
		)
		{
				_timeout(cancel, life, bye
					, extended4usr2close,  waitAftKilling
					);

		}

		public OnDue0cancel(ProcessStartInfo info, CancellationToken  cancel, int? life=null, int? bye=null
			, int? extended4usr2close = null, int? waitAftKilling = null
		) : this(
			new nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr(info),cancel,life,bye, extended4usr2close,  waitAftKilling
		)
		{
	}

		public OnDue0cancel(PrepI info, CancellationToken  cancel, int? life=null, int? bye=null, int? extended4usr2close = null, int? waitAftKilling = null) : this(
			info.info,cancel,life,bye, extended4usr2close,  waitAftKilling

		)
		{

		}
		public OnDue0cancel(PrepA info, CancellationToken  cancel, int? life=null, int? bye=null, int? extended4usr2close = null, int? waitAftKilling = null) : this(
			(PrepI)info,cancel,life,bye, extended4usr2close,  waitAftKilling
		)
		{

		}

		public OnDue0cancel(string cmd, string arg , string dir 
			,
			CancellationToken cancel
			,
	int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
) :
	this(
	new nilnul.os.prog.prep_.nonshell_.RedirStd(cmd, arg, dir), cancel, life
	, bye
, extended4usr2close, waitAftKilling

)
		{
		}

		public OnDue0cancel(string cmd, string arg, ShieldI dir
			,
			CancellationToken cancel
			,
			int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
) :
				this(
			new nilnul.os.prog.prep_.nonshell_.RedirStd(cmd, arg, dir), cancel, life
			, bye
, extended4usr2close, waitAftKilling

		)

		{
		}

		public OnDue0cancel(
			string cmd, string arg, FolderI dir
			,
			CancellationToken cancel
			,
			int? life = null, int? bye = null, int? extended4usr2close = null, int? waitAftKilling = null
) :
				this(
			new nilnul.os.prog.prep_.nonshell_.RedirStd(cmd, arg, dir),cancel, life
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
			 os.proc_.started.abort_.throwQuitTimeout_._OnDue0cancelX.Vod(boxed,  life,cancel, bye,waitAftKilling);
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
