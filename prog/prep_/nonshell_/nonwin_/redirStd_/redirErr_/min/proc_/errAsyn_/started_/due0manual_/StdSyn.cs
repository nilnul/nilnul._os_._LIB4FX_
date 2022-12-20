using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_.min.proc_.errAsyn_.started_.due0manual_
{
	public class StdSyn 
		: OnDue0cancel
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



		public StdSyn(nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info
			, int? life = null, int? bye = null,int? waitAftKill=null, CancellationToken  cancel=default) : base(
			
			
				info, life, bye,waitAftKill, cancel
			
			
		)
		{
			this.waitAftKill = waitAftKill;
			readAll();
		}
		public StdSyn(nilnul.os.prog.prep_.nonshell_.RedirStd info
			,
			int? life = null, int? bye = null
			,
			int? wait=null
			, CancellationToken  cancel=default
		) : this(
			new os.prog.prep_.nonshell_.redirStd_.RedirErr(info)
			,
			life, bye,wait			,
			cancel

		)
		{
		}

		public StdSyn(os.prog.prep_.Nonshell val
			,
			int? life = null, int? bye = null,int? wait=null, CancellationToken  cancel=default
		) : this(
			new os.prog.prep_.nonshell_.RedirStd(val)
			, life
			, bye
			,wait
			,
			cancel
		)

		{
		}


		public StdSyn(PrepI val
			,
			int? life = null, int? bye = null,int? wait=null, CancellationToken  cancel=default
		) : this(
			new os. prog.prep_.Nonshell(val)
			, life
			, bye
			,wait
			,
			cancel

			)
		{
		}
		public StdSyn(Prep val
			,
			int? life = null, int? bye = null,int? wait=null, CancellationToken  cancel=default
		) : this(
			new os. prog.prep_.Nonshell(val)
			, life
			, bye
			,wait
			,
			cancel

			)
		{
		}
		public StdSyn(PrepA val
			,
			int? life = null
			,
			int? bye = null
			,
			int? wait=null
			,
			CancellationToken  cancel=default
		) : this(
			(PrepI)(val)
			, life
			, bye
			,
			wait
			,
			cancel

			)
		{
		}

		public StdSyn(
			ProcessStartInfo val, int? life = null, int? bye = null, int? wait = null, CancellationToken cancel = default
		) : this(
			new os.prog.prep_.Nonshell(val), life, bye, wait, cancel
		)
		{
		}

		public StdSyn(
			string cmd, string arg = null, string dir = null
			,
			int? life = null, int? bye = null
			,
			int? wait=null
			, CancellationToken  cancel=default
		)
		:
		this(
				new Prep(cmd, arg, dir), life
				, bye,wait,cancel
			)
		{
		}

		public StdSyn(
			string cmd, string arg, ShieldI dir
			,
			int? life = null, int? bye = null
			,
			int? wait=null
			, CancellationToken  cancel=default

		) :
		this(
			new Prep(cmd, arg, dir), life
			, bye,wait,cancel
		)

		{
		}

		public StdSyn(string cmd, string arg, FolderI dir,
			int? life = null, int? bye = null
			,
			int? wait=null
			, CancellationToken  cancel=default
		) :
		this(
			new Prep(cmd, arg, dir), life
			,
			bye
			,wait
			,cancel
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





		public static StdSyn InSeconds(ProcessStartInfo timeout, int? life=null, int? bye=null,int? wait=null, CancellationToken  cancel=default)
		{
			return new StdSyn(
				timeout
				,
				life==null?(int?)null:life.Value *1000
				,
				bye==null?(int?)null:bye.Value  *1000
				,
				wait==null?(int?)null:wait.Value  *1000

				,cancel
			);
		}
	}
}
