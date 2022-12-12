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
			nilnul.os.prog.prep_.shell_.win_.Hid info
			, int? lurk
			, int? loomAftLurk = null
			, int? bye = null
			, CancellationTokenSource cancelSrc = default
		) : base(


				info
				, lurk
				,
				cancelSrc.Token


		)
		{
			_cancelSrc = cancelSrc;
			_end(
				loomAftLurk is null ? os.Properties.SettingsX._Life4proc() : (os.Properties.SettingsX._Lurk(lurk) + loomAftLurk.Value)
				,
				bye
				,
				cancelSrc
			);
		}


		public OnDue_loomAftLurk(
			nilnul.os.prog.prep_.shell_.win_.Hid info
			,
			int? lurk
			,
			int? life = null, int? bye = null
		) : this(
			(info),
			lurk
			,
			life,
			bye
			,
			new CancellationTokenSource()

		)
		{



		}


		public OnDue_loomAftLurk(Win val
			, int? lurk = null
			,
			int? life = null, int? bye = null
		) : this(
			new shell_.win_.Hid(val)
			,
			lurk
			, life
			, bye
			)

		{
		}

		public OnDue_loomAftLurk(Shell val
			, int? lurk = null
			,
			int? life = null, int? bye = null
		) : this(
			new shell_.Win(val)
			,
			lurk
			, life
			, bye
		)

		{
		}


		public OnDue_loomAftLurk(PrepI val
			,
			int? lurk = null
			,
			int? life = null, int? bye = null
) : this(
			new Shell(val)
	,
			lurk
			, life
			, bye

			)
		{
		}
		public OnDue_loomAftLurk(PrepA val,
			int? lurk = null
			,
			int? life = null
			,
			int? bye = null
		) : this(
			(PrepI)(val)
			,
			lurk
			, life
			, bye

			)
		{
		}


		public OnDue_loomAftLurk(Prep val
			,
			int? lurk = null
				,
			int? life = null, int? bye = null

			) : this(
			(PrepI)(val)
				,
			lurk
			, life
			, bye
		)
		{
		}
		public OnDue_loomAftLurk(ProcessStartInfo val, int? lurk = null, int? life = null, int? bye = null) : this(new Nonshell(val), lurk, life, bye)
		{
		}

		public OnDue_loomAftLurk(string cmd, string arg = null, string dir = null,
			int? lurk = null
			,
			int? life = null, int? bye = null
) :
			this(
			new Prep(cmd, arg, dir), lurk, life
			, bye

		)
		{
		}

		public OnDue_loomAftLurk(string cmd, string arg, ShieldI dir,
			int? lurk = null
			,
			int? life = null, int? bye = null
) :
				this(
			new Prep(cmd, arg, dir), lurk, life
			, bye

		)

		{
		}

		public OnDue_loomAftLurk(string cmd, string arg, FolderI dir, int? lurk = null, int? life = null, int? bye = null) : this(new Prep(cmd, arg, dir), lurk, life, bye)
		{
		}

		private void _end(
			 int? life
			, int? bye
			,
			CancellationTokenSource token

			)
		{
			Trace.TraceInformation("aborting...");
			os.proc_.started.abort_._OnDueX.Vod(
					boxed
					,
					life
					,

					bye
			);

			token.Cancel();



			//Trace.TraceInformation("cancelling lurk");
			//Trace.TraceInformation("let out task exception");




		}
		/// <summary>
		/// to be verified: exitCode is -1 if the process is ended early.
		/// </summary>
		/// <returns></returns>
		public int cod => boxed.ExitCode;


		public static OnDue_loomAftLurk InSeconds(ProcessStartInfo timeout
			, int? lurk = null
			, int? life = null, int? bye = null)
		{
			return new OnDue_loomAftLurk(
				timeout
				,
				lurk == null ? (int?)null : lurk.Value * 1000
				,
				life == null ? (int?)null : life.Value * 1000
				,
				bye == null ? (int?)null : bye.Value * 1000
			);
		}
	}
}
