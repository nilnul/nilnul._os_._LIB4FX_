﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.nonshell_.nonwin_.redirStd_.redirErr.proc_.errAsyn_.started_.doodle_.stdSyn_
{
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete(nameof(started_.stdSyn_.exit_.abort_.OnDue))]
	public class Waited 
		: StdSyn

	{
		private CancellationTokenSource _cancelSrc;

		public CancellationTokenSource cancelSrc
		{
			get { return _cancelSrc; }
			set { _cancelSrc = value; }
		}

		

		private Waited(
			RedirErr info, CancellationTokenSource cancelSrc, int? life = null, int? bye = null
			//,int? waitAftKill=null
		) : base(
			
			
				info, cancelSrc.Token, life, bye//,waitAftKill
			
			
		)
		{
			_cancelSrc = cancelSrc;
			_end();
		}
		public Waited(RedirStd info
			,
			int? life = null, int? bye = null
			//,int? waitAftKill=null
		) : this(
			new RedirErr(info),
			new CancellationTokenSource()
			,
			life, bye
			//,waitAftKill
		)
		{
		}

		public Waited(Nonshell val
			,
			int? life = null, int? bye = null
			//, int? waitAftKill=null
		) : this(
			new RedirStd(val)
			, life
			, bye
			//,waitAftKill
			)

		{
		}


		public Waited(PrepI val
			,
			int? life = null, int? bye = null
) : this(
			new Nonshell(val)
			, life
			, bye

			)
		{
		}
		public Waited(PrepA val,
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

		public Waited(Prep val
				,
			int? life = null, int? bye = null
			//,int? waitAftKill=null

			) : this(
			new Nonshell(val)
			, life
			, bye
				//,waitAftKill
		)
		{
		}
		public Waited(ProcessStartInfo val
				,
			int? life = null, int? bye = null

			) : this(
			new Nonshell(val)
			, life
			, bye
		)
		{
		}

		public Waited(string cmd, string arg = null, string dir = null,
			int? life = null, int? bye = null
			//,int? waitAftKill=null
) :
			this(
			new Prep(cmd, arg, dir), life
			, bye//,waitAftKill

		)
		{
		}

		public Waited(string cmd, string arg, ShieldI dir,
			int? life = null, int? bye = null
) :
				this(
			new Prep(cmd, arg, dir), life
			, bye

		)

		{
		}

		public Waited(string cmd, string arg, FolderI dir,
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
		public os.proc_.finished._result.CodMsgErr result => new os.proc_.finished._result.CodMsgErr(boxed.ExitCode, base.msg, base.err);


		public static Waited InSeconds(ProcessStartInfo timeout, int? life=null, int? bye=null)
		{
			return new Waited(
				timeout
				,
				life==null?(int?)null:life.Value *1000
				,
				bye==null?(int?)null:bye.Value  *1000
			);
		}
	}
}
