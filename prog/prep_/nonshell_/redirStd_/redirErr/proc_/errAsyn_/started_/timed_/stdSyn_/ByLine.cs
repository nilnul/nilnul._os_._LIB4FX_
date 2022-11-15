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

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.started_.timed_.stdSyn_
{
	public class ByLine 
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



		public ByLine(nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info, CancellationToken  cancelSrc=default, int? life = null, int? bye = null,int? waitAftKill=null) : base(
			
			
				info, cancelSrc, life, bye,waitAftKill
			
			
		)
		{
			this.waitAftKill = waitAftKill;
			readAll();
		}
		public ByLine(nilnul.os.prog.prep_.nonshell_.RedirStd info, CancellationToken  cancel=default
			,
			int? life = null, int? bye = null
		) : this(
			new RedirErr(info)
			,
			cancel
			,
			life, bye
		)
		{
		}

		public ByLine(Nonshell val, CancellationToken  cancel=default
			,
			int? life = null, int? bye = null
		) : this(
			new RedirStd(val),
			cancel
			, life
			, bye
			)

		{
		}


		public ByLine(PrepI val, CancellationToken  cancel=default
			,
			int? life = null, int? bye = null
		) : this(
			new Nonshell(val),
			cancel
			, life
			, bye

			)
		{
		}
		public ByLine(PrepA val, CancellationToken  cancel=default,
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

		public ByLine(Prep val, CancellationToken  cancel=default
				,
			int? life = null, int? bye = null

			) : this(
			new Nonshell(val),
			cancel
			, life
			, bye
		)
		{
		}
		public ByLine(ProcessStartInfo val, CancellationToken  cancel=default
				,
			int? life = null, int? bye = null

			) : this(
			new Nonshell(val),
			cancel
			, life
			, bye
		)
		{
		}

		public ByLine(
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

		public ByLine(
			string cmd, string arg, ShieldI dir, CancellationToken  cancel=default,
			int? life = null, int? bye = null
		) :
		this(
			new Prep(cmd, arg, dir),cancel, life
			, bye
		)

		{
		}

		public ByLine(string cmd, string arg, FolderI dir, CancellationToken  cancel=default,
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
			//_msg = boxed.StandardOutput.ReadToEnd();

			#endregion

			var buffer = new StringBuilder();
			string t;// = boxed.StandardOutput.ReadLine();

			while ((t = boxed.StandardOutput.ReadLine()) is not null)
			{
				buffer.AppendLine(t);
				Console.WriteLine(t);

				//t=boxed.StandardOutput.ReadLine();
			}
			_msg = buffer.ToString();




		}


		//private  void read()
		//{

		//	// To avoid deadlocks, always read the output stream first and then wait.  
		//	_msg = boxed.StandardOutput.ReadToEnd();
		//	//boxed.WaitForExit();
		//	//_cancelSrc.Cancel();

		//	//return new win.prog._run.Result(boxed.ExitCode, r, this.err);

		//}



		public static ByLine InSeconds(ProcessStartInfo timeout, CancellationToken  cancel=default, int? life=null, int? bye=null)
		{
			return new ByLine(
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
