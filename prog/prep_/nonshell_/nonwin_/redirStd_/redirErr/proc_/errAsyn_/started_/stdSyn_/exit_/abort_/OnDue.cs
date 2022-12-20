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
	public class OnDue
		: StdSyn

	{
		



		private OnDue(
			RedirErr info, int? life = null, int? bye = null, int? waitAftKill = null) : base(


				info


		)
		{
			_end(
				
				life,
				bye
				,
				waitAftKill
			);
		}


		public OnDue(RedirStd info
			,
			int? life = null, int? bye = null, int? waitAftKill = null
		) : this(
			new RedirErr(info)
			,
			life, bye, waitAftKill
		)
		{
		}

		public OnDue(Nonshell val
			,
			int? life = null, int? bye = null, int? waitAftKill = null
		) : this(
			new RedirStd(val)
			, life
			, bye, waitAftKill
			)

		{
		}


		public OnDue(PrepI val
			,
			int? life = null, int? bye = null
) : this(
			new Nonshell(val)
			, life
			, bye

			)
		{
		}
		public OnDue(PrepA val,
			int? life = null
			,
			int? bye = null
		) : this(
			(PrepI)(val)
			, life
			, bye

			)
		{
		}

		public OnDue(Prep val
				,
			int? life = null, int? bye = null, int? waitAftKill = null

			) : this(
			new Nonshell(val)
			, life
			, bye, waitAftKill
		)
		{
		}
		public OnDue(ProcessStartInfo val
				,
			int? life = null, int? bye = null

			) : this(
			new Nonshell(val)
			, life
			, bye
		)
		{
		}

		public OnDue(string cmd, string arg = null, string dir = null,
			int? life = null, int? bye = null, int? waitAftKill = null
) :
			this(
			new Prep(cmd, arg, dir), life
			, bye, waitAftKill

		)
		{
		}

		public OnDue(string cmd, string arg, ShieldI dir,
			int? life = null, int? bye = null
) :
				this(
			new Prep(cmd, arg, dir), life
			, bye

		)

		{
		}

		public OnDue(string cmd, string arg, FolderI dir,
			int? life = null, int? bye = null
) :
				this(
			new Prep(cmd, arg, dir), life
			, bye

		)
		{
		}

		private void _end( int? life, int? bye, int? waitAftKill)
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
		public os.proc_.finished._result.CodMsgErr result => new os.proc_.finished._result.CodMsgErr(boxed.ExitCode, base.msg, base.err);


		public static OnDue InSeconds(ProcessStartInfo timeout, int? life = null, int? bye = null)
		{
			return new OnDue(
				timeout
				,
				life == null ? (int?)null : life.Value * 1000
				,
				bye == null ? (int?)null : bye.Value * 1000
			);
		}
	}
}
