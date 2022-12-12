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
	public class Due0manual_loomAftLurk
		: Loom

	{
		private CancellationTokenSource _cancelSrc;

		public CancellationTokenSource cancelSrc
		{
			get { return _cancelSrc; }
			set { _cancelSrc = value; }
		}



		private Due0manual_loomAftLurk(
			nilnul.os.prog.prep_.shell_.win_.Hid info
			, int? lurk
			, CancellationTokenSource cancelSrc
			, int? loomAftLurk = null
			, int? bye = null
			, int? waitAftKill = null
		) : base(


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
				loomAftLurk is null ? os.Properties.SettingsX._Life4proc() : (os.Properties.SettingsX._Lurk(lurk) + loomAftLurk.Value),
				bye
				,
				waitAftKill
			);
		}


		public Due0manual_loomAftLurk(nilnul.os.prog.prep_.shell_.win_.Hid info
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


		public Due0manual_loomAftLurk(Win val
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

		public Due0manual_loomAftLurk(Shell val
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


		public Due0manual_loomAftLurk(PrepI val
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
		public Due0manual_loomAftLurk(PrepA val,
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


		public Due0manual_loomAftLurk(Prep val
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
		public Due0manual_loomAftLurk(ProcessStartInfo val
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

		public Due0manual_loomAftLurk(string cmd, string arg = null, string dir = null,
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

		public Due0manual_loomAftLurk(string cmd, string arg, ShieldI dir,
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

		public Due0manual_loomAftLurk(string cmd, string arg, FolderI dir,
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
			Trace.TraceInformation("aborting...");
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


			//Trace.TraceInformation("cancelling lurk");
			//Trace.TraceInformation("let out task exception");




		}
		/// <summary>
		/// to be verified: exitCode is -1 if the process is ended early.
		/// </summary>
		/// <returns></returns>
		public int cod => boxed.ExitCode;


		public static Due0manual_loomAftLurk InSeconds(ProcessStartInfo timeout, int? life = null, int? bye = null, int? aftKill = null)
		{
			return new Due0manual_loomAftLurk(
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
