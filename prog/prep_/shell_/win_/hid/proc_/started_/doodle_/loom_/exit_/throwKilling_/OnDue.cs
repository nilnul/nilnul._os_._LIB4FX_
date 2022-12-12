using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;
using nilnul.os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.exit_.throwKilling_
{
	public class OnDue
		: Loom

	{
		private CancellationTokenSource _cancelSrc4Lurk;

		public CancellationTokenSource cancelSrc4Lurk
		{
			get { return _cancelSrc4Lurk; }
			set { _cancelSrc4Lurk = value; }
		}



		private OnDue(
			nilnul.os.prog.prep_.shell_.win_.Min info, int? lurk, CancellationTokenSource lurk_cancelSrc, int? life = null, int? bye = null, int? waitAftKill = null) : base(

				info
				, lurk
				,
				lurk_cancelSrc.Token


		)
		{
			_cancelSrc4Lurk = lurk_cancelSrc;
			_end(
				lurk_cancelSrc
				,
				life,
				bye
				,
				waitAftKill
			);
		}


		public OnDue(nilnul.os.prog.prep_.shell_.win_.Min info
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
			new shell_.win_.Min(val)
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

		//private Task task;

		private void _end(CancellationTokenSource cancelSrc, int? life, int? bye, int? waitAftKill)
		{
#if Symbol
			Debug.WriteLine("aborting...");

#endif


			
			os.proc_.started.abort_.throwKilling_._OnDueX.Vod(
					boxed
					,
					life
					,

					bye
					,
					waitAftKill
			);

#if Symbol
			Debug.WriteLine("cancelling lurk");

#endif

			cancelSrc.Cancel();
#if Symbol
			Debug.WriteLine("let out task exception");

#endif






		}
		/// <summary>
		/// to be verified: exitCode is -1 if the process is ended early.
		/// </summary>
		/// <returns></returns>
		public int cod
		{
			get
			{

				return boxed.ExitCode;
			}
		}

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
