using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started_.exit_
{
	public class OnDue
		: Started

	{
		private CancellationTokenSource _cancelSrc;

		public CancellationTokenSource cancelSrc
		{
			get { return _cancelSrc; }
			set { _cancelSrc = value; }
		}



		private OnDue(
			nilnul.os.prog.prep_.shell_.win_.Min info
			,
			CancellationTokenSource cancelSrc
			, int? life = null
			,
			int? bye = null, int? waitAftKill = null
		) : base(
			info
		)
		{
			_cancelSrc = cancelSrc;
			_end(
				cancelSrc
				, life
				,
				bye
				,
				waitAftKill
			);
		}


		public OnDue(nilnul.os.prog.prep_.shell_.win_.Min info
			, int? life = null
			,
			  int? bye = null, int? waitAftKill = null
		) : this(
			info,
			new CancellationTokenSource()
			, life
			,

			bye,
			waitAftKill

		)
		{



		}


		public OnDue(Win val
			,
			int? life = null
			,
			  int? bye = null, int? waitAftKill = null
		) : this(
			new shell_.win_.Min(val)
			, life

			, bye, waitAftKill
			)

		{
		}

		public OnDue(Shell val
			,
			int? life = null
			,
			  int? bye = null, int? waitAftKill = null
		) : this(
			new shell_.Win(val)
			,
			life

			, bye, waitAftKill
			)

		{
		}


		public OnDue(PrepI val
			,
			int? life = null
			,
			  int? bye = null, int? waitAftKill = null
) : this(
			new Shell(val)
	,
			life

			, bye, waitAftKill

			)
		{
		}
		public OnDue(PrepA val,
			int? life = null
			,
			int? bye = null, int? waitAftKill = null
		) : this(
			(PrepI)(val)
			,
			life

			, bye, waitAftKill

			)
		{
		}


		public OnDue(Prep val
			,
			int? life = null
				,
			  int? bye = null, int? waitAftKill = null

			) : this(
			(PrepI)(val)

			, bye, waitAftKill
		)
		{
		}
		public OnDue(ProcessStartInfo val
			,
			int? life = null
				,
			  int? bye = null, int? waitAftKill = null

			) : this(
			new Nonshell(val)
			 ,
			life
			, bye, waitAftKill
		)
		{
		}

		public OnDue(string cmd, string arg = null, string dir = null
			,
			int? life = null,
			  int? bye = null, int? waitAftKill = null
) :
			this(
			new Prep(cmd, arg, dir)
				,
			life
			, bye, waitAftKill

		)
		{
		}

		public OnDue(string cmd, string arg, ShieldI dir,
			int? life = null
			,
			  int? bye = null, int? waitAftKill = null
) :
				this(
			new Prep(cmd, arg, dir)
					,
			life
			, bye, waitAftKill

		)

		{
		}

		public OnDue(string cmd, string arg, FolderI dir,
			int? life = null
			,
			  int? bye = null, int? waitAftKill = null
) :
				this(
			new Prep(cmd, arg, dir)
			, bye, waitAftKill

		)
		{
		}

		private void _end(CancellationTokenSource cancelSrc, int? life, int? bye, int? waitAftKill)
		{

			os.proc_.started.abort_.throwKilling_._OnDueX.Vod(
					boxed
					,
					life
					,

					bye
					,
					waitAftKill
			);




		}
		/// <summary>
		/// to be verified: exitCode is -1 if the process is ended early.
		/// </summary>
		/// <returns></returns>
		public int cod => boxed.ExitCode;


		public static OnDue InSeconds(ProcessStartInfo timeout, int? life = null, int? bye = null, int? aftKill = null)
		{
			return new OnDue(
				timeout
				,
				life == null ? (int?)null : life.Value * 1000
				,
				bye == null ? (int?)null : bye.Value * 1000
				,
				aftKill == null ? (int?)null : aftKill.Value * 1000
			);
		}
	}
}
