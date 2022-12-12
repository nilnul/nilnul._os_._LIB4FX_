using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_.min.proc_.errAsyn_.started_.due0manual_.stdSyn_
{
	public class Exit 
		: StdSyn

	{
		private CancellationTokenSource _cancelSrc;

		public CancellationTokenSource cancelSrc
		{
			get { return _cancelSrc; }
			set { _cancelSrc = value; }
		}

		

		public Exit(
			nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info
			, int? life = null, int? bye = null,int? waitAftKill=null
			, CancellationTokenSource cancelSrc=default
		) : base(
			
			
				info, life, bye,waitAftKill, cancelSrc.Token
			
			
		)
		{
			_cancelSrc = cancelSrc;
			_end();
		}
		public Exit(nilnul.os.prog.prep_.nonshell_.RedirStd info
			,
			int? life = null, int? bye = null,int? waitAftKill=null
		) : this(
			new RedirErr(info)
			,
			life, bye,waitAftKill
			,
			new CancellationTokenSource()
		)
		{
		}

		public Exit(Nonshell val
			,
			int? life = null, int? bye = null, int? waitAftKill=null
		) : this(
			new RedirStd(val)
			, life
			, bye,waitAftKill
			)

		{
		}


		public Exit(PrepI val
			,
			int? life = null, int? bye = null
) : this(
			new Nonshell(val)
			, life
			, bye

			)
		{
		}
		public Exit(PrepA val,
			int? life = null
			,
			int? bye = null
		) : this(
			(PrepI)(val)
			, life
			, bye

			)
		{
		}

		public Exit(Prep val
				,
			int? life = null, int? bye = null,int? waitAftKill=null

			) : this(
			new Nonshell(val)
			, life
			, bye,waitAftKill
		)
		{
		}
		public Exit(ProcessStartInfo val
				,
			int? life = null, int? bye = null

			) : this(
			new Nonshell(val)
			, life
			, bye
		)
		{
		}

		public Exit(string cmd, string arg = null, string dir = null,
			int? life = null, int? bye = null,int? waitAftKill=null
) :
			this(
			new Prep(cmd, arg, dir), life
			, bye,waitAftKill

		)
		{
		}

		public Exit(string cmd, string arg, ShieldI dir,
			int? life = null, int? bye = null
) :
				this(
			new Prep(cmd, arg, dir), life
			, bye

		)

		{
		}

		public Exit(string cmd, string arg, FolderI dir,
			int? life = null, int? bye = null
) :
				this(
			new Prep(cmd, arg, dir), life
			, bye

		)
		{
		}


		private  void _end()
		{

			// To avoid deadlocks, always read the output stream first and then wait.  
			boxed.WaitForExit();
			_cancelSrc.Cancel();
			_cancelSrc.Dispose();

			//return new nilnul.os.proc_.finished._result.CodMsgErr(boxed.ExitCode, r, this.err);

		}
		/// <summary>
		/// to be verified: exitCode is -1 if the process is ended early.
		/// </summary>
		/// <returns></returns>
		public os.proc_.finished._result.CodMsgErr result()
		{

			

			return new os.proc_.finished._result.CodMsgErr(boxed.ExitCode, base.msg, base.err);

		}


		public static Exit InSeconds(ProcessStartInfo timeout, int? life=null, int? bye=null)
		{
			return new Exit(
				timeout
				,
				life==null?(int?)null:life.Value *1000
				,
				bye==null?(int?)null:bye.Value  *1000
			);
		}
	}
}
