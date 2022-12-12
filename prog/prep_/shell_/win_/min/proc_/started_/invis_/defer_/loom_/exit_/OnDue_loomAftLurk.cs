using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started_.invis_.defer_.loom_.exit_
{
	public class OnDue_loomAftLurk
		: Loom

	{
		private CancellationTokenSource _cancelSrc;

		public CancellationTokenSource cancelSrc
		{
			get { return _cancelSrc; }
			set { _cancelSrc = value; }
		}



		private OnDue_loomAftLurk(
			nilnul.os.prog.prep_.shell_.win_.Min info, int? lurk, CancellationTokenSource cancelSrc, int? loomAftLurk = null, int? bye = null, int? waitAftKill = null) : base(

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
				loomAftLurk is null ? os.Properties.SettingsX._Life4proc() : (os.Properties.SettingsX._Lurk(lurk) + loomAftLurk.Value)
				,
				bye
				,
				waitAftKill
			);
		}


		public OnDue_loomAftLurk(nilnul.os.prog.prep_.shell_.win_.Min info
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


		public OnDue_loomAftLurk(Win val
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

		public OnDue_loomAftLurk(Shell val
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


		public OnDue_loomAftLurk(PrepI val
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
		public OnDue_loomAftLurk(PrepA val,
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


		public OnDue_loomAftLurk(Prep val
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
		public OnDue_loomAftLurk(ProcessStartInfo val
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

		public OnDue_loomAftLurk(string cmd, string arg = null, string dir = null,
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

		public OnDue_loomAftLurk(string cmd, string arg, ShieldI dir,
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

		public OnDue_loomAftLurk(string cmd, string arg, FolderI dir,
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

		private Task task;

		private void _end(CancellationTokenSource cancelSrc, int? life, int? bye, int? waitAftKill)
		{
#if Symbol
			Debug.WriteLine("aborting...");

#endif
			try
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
		public int cod
		{
			get
			{
				task.Wait();// let out the exception: not return;

				return boxed.ExitCode;
			}
		}

		public static OnDue_loomAftLurk InSeconds(ProcessStartInfo timeout, int? life = null, int? bye = null, int? aftKill = null)
		{
			return new OnDue_loomAftLurk(
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
