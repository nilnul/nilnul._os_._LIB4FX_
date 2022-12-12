using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.exit_
{
	public class OnDue
		: Loom

	{
		private CancellationTokenSource _cancelSrc;

		public CancellationTokenSource cancelSrc
		{
			get { return _cancelSrc; }
			set { _cancelSrc = value; }
		}



		private OnDue(
			nilnul.os.prog.prep_.shell_.win_.Hid info, int? lurk, CancellationTokenSource cancelSrc, int? life = null, int? bye = null, int? waitAftKill = null) : base(


				info
				, lurk
				,
				cancelSrc.Token


		)
		{
			_cancelSrc = cancelSrc;
			_end(
				cancelSrc
				,
				life,
				bye
				,
				waitAftKill
			);
		}


		public OnDue(nilnul.os.prog.prep_.shell_.win_.Hid info
			,
			int? lurk
			,
			int? life = null, int? bye = null, int? waitAftKill = null
		) : this(
			(info),
			lurk,
			new CancellationTokenSource()
			,
			life,
			bye,
			waitAftKill

		)
		{



		}


		public OnDue(Win val
			, int? lurk = null
			,
			int? life = null, int? bye = null, int? waitAftKill = null
		) : this(
			new shell_.win_.Hid(val)
			,
			lurk
			, life
			, bye, waitAftKill
			)

		{
		}

		public OnDue(Shell val
			, int? lurk = null
			,
			int? life = null, int? bye = null, int? waitAftKill = null
		) : this(
			new shell_.Win(val)
			,
			lurk
			, life
			, bye, waitAftKill
			)

		{
		}


		public OnDue(PrepI val
			,
			int? lurk = null
			,
			int? life = null, int? bye = null, int? waitAftKill = null
) : this(
			new Shell(val)
	,
			lurk
			, life
			, bye, waitAftKill

			)
		{
		}
		public OnDue(PrepA val,
			int? lurk = null
			,
			int? life = null
			,
			int? bye = null, int? waitAftKill = null
		) : this(
			(PrepI)(val)
			,
			lurk
			, life
			, bye, waitAftKill

			)
		{
		}


		public OnDue(Prep val
			,
			int? lurk = null
				,
			int? life = null, int? bye = null, int? waitAftKill = null

			) : this(
			(PrepI)(val)
				,
			lurk
			, life
			, bye, waitAftKill
		)
		{
		}
		public OnDue(ProcessStartInfo val
			,
			int? lurk = null
				,
			int? life = null, int? bye = null, int? waitAftKill = null

			) : this(
			new Nonshell(val)
				,
			lurk
			, life
			, bye, waitAftKill
		)
		{
		}

		public OnDue(string cmd, string arg = null, string dir = null,
			int? lurk = null
			,
			int? life = null, int? bye = null, int? waitAftKill = null
) :
			this(
			new Prep(cmd, arg, dir), lurk, life
			, bye, waitAftKill

		)
		{
		}

		public OnDue(string cmd, string arg, ShieldI dir,
			int? lurk = null
			,
			int? life = null, int? bye = null, int? waitAftKill = null
) :
				this(
			new Prep(cmd, arg, dir), lurk, life
			, bye, waitAftKill

		)

		{
		}

		public OnDue(string cmd, string arg, FolderI dir,
			int? lurk = null
			,
			int? life = null, int? bye = null, int? waitAftKill = null
) :
				this(
			new Prep(cmd, arg, dir), lurk, life
			, bye, waitAftKill

		)
		{
		}

		private void _end(CancellationTokenSource cancelSrc, int? life, int? bye, int? waitAftKill)
		{
#if Symbol
			Debug.WriteLine("aborting...");

#endif

			try
			{
				os.proc_.started.abort_.throwQuitTimeout_._OnDueX.Vod(
						boxed
						,
						life
						,

						bye
						,
						waitAftKill
				);

			}
			finally
			{
				cancelSrc.Cancel();

			}
#if Symbol
			Debug.WriteLine("cancelling lurk");

#endif


#if Symbol
			Debug.WriteLine("let out task exception");

#endif





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
