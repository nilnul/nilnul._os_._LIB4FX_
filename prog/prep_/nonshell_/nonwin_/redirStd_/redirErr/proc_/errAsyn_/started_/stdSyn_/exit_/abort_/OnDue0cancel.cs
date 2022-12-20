using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.nonshell_.nonwin_.redirStd_.redirErr.proc_.errAsyn_.started_.stdSyn_.exit_.abort_
{
	public class OnDue0cancel
		: StdSyn

	{



		public OnDue0cancel(
			RedirErr info
			,
			int? life
			,
			CancellationToken cancelSrc
			,
			int? bye = null
			,
			int? waitAftKill = null
		) : base(
			info
		)
		{
			_end(
				life,
				cancelSrc
				,
				bye
				,
				waitAftKill
			);
		}


		public OnDue0cancel(
			RedirStd info
			,
			int? life
			,
			CancellationToken cancel
			,
			int? bye = null, int? waitAftKill = null
		) : this(
			new RedirErr(info),
			life
			, cancel
			,
			bye, waitAftKill
		)
		{
		}

		public OnDue0cancel(
			Nonshell val
			,
			int? life,
			CancellationToken cancel
, int? bye = null, int? waitAftKill = null
		) : this(
			new RedirStd(val)
			, life
			, cancel

			, bye, waitAftKill
			)

		{
		}


		public OnDue0cancel(PrepI val
			,
			int? life,
			CancellationToken cancel
, int? bye = null, int? waitAftKill = null
) : this(
			new Nonshell(val)
			, life
			, cancel
			, bye,waitAftKill

			)
		{
		}
		public OnDue0cancel(PrepA val,
			int? life, CancellationToken cancel
			,
			int? bye = null, int? waitAftKill = null
		) : this(
			(PrepI)(val)
			, life
			, cancel
			, bye,waitAftKill

			)
		{
		}

		public OnDue0cancel(Prep val
				,
			int? life,
			CancellationToken cancel
, int? bye = null, int? waitAftKill = null

			) : this(
			new Nonshell(val)
			, life
			, cancel
			, bye, waitAftKill
		)
		{
		}
		public OnDue0cancel(ProcessStartInfo val
				,
			int? life,
			CancellationToken cancel
, int? bye = null
			,
			int? waitAftKill = null

			) : this(
			new Nonshell(val)
			, life
			, cancel
			, bye
				,
			waitAftKill
		)
		{
		}

		public OnDue0cancel(string cmd, string arg, string dir,
			int? life,
			CancellationToken cancel
, int? bye = null, int? waitAftKill = null
) :
			this(
			new Prep(cmd, arg, dir), life
			, cancel
			, bye, waitAftKill

		)
		{
		}

		public OnDue0cancel(string cmd, string arg, ShieldI dir,
			int? life,
			CancellationToken cancel
, int? bye = null, int? waitAftKill = null
) :
				this(
			new Prep(cmd, arg, dir), life
			, cancel
			, bye, waitAftKill

		)

		{
		}

		public OnDue0cancel(string cmd, string arg, FolderI dir,
			int? life, CancellationToken cancel, int? bye = null, int? waitAftKill = null
		) :
		this(
			new Prep(cmd, arg, dir), life, cancel
			, bye, waitAftKill

		)
		{
		}

		private void _end(int? life, CancellationToken cancelSrc, int? bye, int? waitAftKill)
		{

			os.proc_.started.abort_.throwQuitTimeout_._OnDue0cancelX.Vod(
					boxed
					,
					life
					,
					cancelSrc
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
		public os.proc_.finished._result.CodMsgErr result => new os.proc_.finished._result.CodMsgErr(boxed.ExitCode, base.msg, base.err);


		public static OnDue0cancel InSeconds(ProcessStartInfo timeout, int? life, CancellationToken cancel, int? bye = null,int? waitAftKill=null)
		{
			return new OnDue0cancel(
				timeout
				,
				life == null ? (int?)null : life.Value * 1000
				,
				cancel
				,
				bye == null ? (int?)null : bye.Value * 1000
				,
				waitAftKill
			);
		}
	}
}
