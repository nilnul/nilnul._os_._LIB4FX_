﻿using System;
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

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_.min.proc_.errAsyn_.started_.timed_.stdSyn_
{
	public class Ended 
		: StdSyn

	{
		private CancellationTokenSource _cancelSrc;

		public CancellationTokenSource cancelSrc
		{
			get { return _cancelSrc; }
			set { _cancelSrc = value; }
		}

		

		public Ended(
			nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info, CancellationTokenSource cancelSrc, int? life = null, int? bye = null,int? waitAftKill=null) : base(
			
			
				info, cancelSrc.Token, life, bye,waitAftKill
			
			
		)
		{
			_cancelSrc = cancelSrc;
			_end();
		}
		public Ended(nilnul.os.prog.prep_.nonshell_.RedirStd info
			,
			int? life = null, int? bye = null,int? waitAftKill=null
		) : this(
			new RedirErr(info),
			new CancellationTokenSource()
			,
			life, bye,waitAftKill
		)
		{
		}

		public Ended(Nonshell val
			,
			int? life = null, int? bye = null, int? waitAftKill=null
		) : this(
			new RedirStd(val)
			, life
			, bye,waitAftKill
			)

		{
		}


		public Ended(PrepI val
			,
			int? life = null, int? bye = null
) : this(
			new Nonshell(val)
			, life
			, bye

			)
		{
		}
		public Ended(PrepA val,
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

		public Ended(Prep val
				,
			int? life = null, int? bye = null,int? waitAftKill=null

			) : this(
			new Nonshell(val)
			, life
			, bye,waitAftKill
		)
		{
		}
		public Ended(ProcessStartInfo val
				,
			int? life = null, int? bye = null

			) : this(
			new Nonshell(val)
			, life
			, bye
		)
		{
		}

		public Ended(string cmd, string arg = null, string dir = null,
			int? life = null, int? bye = null,int? waitAftKill=null
) :
			this(
			new Prep(cmd, arg, dir), life
			, bye,waitAftKill

		)
		{
		}

		public Ended(string cmd, string arg, ShieldI dir,
			int? life = null, int? bye = null
) :
				this(
			new Prep(cmd, arg, dir), life
			, bye

		)

		{
		}

		public Ended(string cmd, string arg, FolderI dir,
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

			//return new win.prog._run.Result(boxed.ExitCode, r, this.err);

		}
		/// <summary>
		/// to be verified: exitCode is -1 if the process is ended early.
		/// </summary>
		/// <returns></returns>
		public os.proc_.finished._result.CodMsgErr result()
		{

			

			return new os.proc_.finished._result.CodMsgErr(boxed.ExitCode, base.msg, base.err);

		}


		public static Ended InSeconds(ProcessStartInfo timeout, int? life=null, int? bye=null)
		{
			return new Ended(
				timeout
				,
				life==null?(int?)null:life.Value *1000
				,
				bye==null?(int?)null:bye.Value  *1000
			);
		}
	}
}
