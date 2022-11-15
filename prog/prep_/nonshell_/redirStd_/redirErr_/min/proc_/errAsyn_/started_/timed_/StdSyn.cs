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

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_.min.proc_.errAsyn_.started_.timed_
{
	public class StdSyn 
		: Timed
	{
		//	private CancellationTokenSource _cancelSrc;

		//	public CancellationTokenSource cancelSrc
		//	{
		//		get { return _cancelSrc; }
		//		set { _cancelSrc = value; }
		//	}

		private int? _waitAftKill;

		public int? waitAftKill
		{
			get { return _waitAftKill; }
			set { _waitAftKill = value; }
		}



		public StdSyn(nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info, CancellationToken  cancelSrc=default, int? life = null, int? bye = null,int? waitAftKill=null) : base(
			
			
				info, cancelSrc, life, bye,waitAftKill
			
			
		)
		{
			this.waitAftKill = waitAftKill;
			readAll();
		}
		public StdSyn(nilnul.os.prog.prep_.nonshell_.RedirStd info, CancellationToken  cancel=default
			,
			int? life = null, int? bye = null
		) : this(
			new os.prog.prep_.nonshell_.redirStd_.RedirErr(info)
			,
			cancel
			,
			life, bye
		)
		{
		}

		public StdSyn(os.prog.prep_.Nonshell val, CancellationToken  cancel=default
			,
			int? life = null, int? bye = null
		) : this(
			new os.prog.prep_.nonshell_.RedirStd(val),
			cancel
			, life
			, bye
			)

		{
		}


		public StdSyn(PrepI val, CancellationToken  cancel=default
			,
			int? life = null, int? bye = null
		) : this(
			new os. prog.prep_.Nonshell(val),
			cancel
			, life
			, bye

			)
		{
		}
		public StdSyn(Prep val, CancellationToken  cancel=default
			,
			int? life = null, int? bye = null
		) : this(
			new os. prog.prep_.Nonshell(val),
			cancel
			, life
			, bye

			)
		{
		}
		public StdSyn(PrepA val, CancellationToken  cancel=default,
			int? life = null
			,
			int? bye = null
		) : this(
			(PrepI)(val),
			cancel
			, life
			, bye

			)
		{
		}

		public StdSyn(ProcessStartInfo val, CancellationToken  cancel=default
				,
			int? life = null, int? bye = null

			) : this(
			new os.prog.prep_.Nonshell(val),
			cancel
			, life
			, bye
		)
		{
		}

		public StdSyn(
			string cmd, string arg = null, string dir = null, CancellationToken  cancel=default,
			int? life = null, int? bye = null
		)
		:
		this(
				new Prep(cmd, arg, dir),cancel, life
				, bye
			)
		{
		}

		public StdSyn(
			string cmd, string arg, ShieldI dir, CancellationToken  cancel=default,
			int? life = null, int? bye = null
		) :
		this(
			new Prep(cmd, arg, dir),cancel, life
			, bye
		)

		{
		}

		public StdSyn(string cmd, string arg, FolderI dir, CancellationToken  cancel=default,
			int? life = null, int? bye = null
		) :
		this(
			new Prep(cmd, arg, dir),cancel, life
			,
			bye
		)
		{
		}
		private string _msg;

		public string msg
		{
			get { return _msg; }
			set { _msg = value; }
		}

		private void readAll()
		{

			#region read all
			// To avoid deadlocks, always read the output stream first and then wait.  
			_msg = boxed.StandardOutput.ReadToEnd();

			#endregion

		



		}





		public static StdSyn InSeconds(ProcessStartInfo timeout, CancellationToken  cancel=default, int? life=null, int? bye=null)
		{
			return new StdSyn(
				timeout
				,cancel
				,
				life==null?(int?)null:life.Value *1000
				,
				bye==null?(int?)null:bye.Value  *1000
			);
		}
	}
}
