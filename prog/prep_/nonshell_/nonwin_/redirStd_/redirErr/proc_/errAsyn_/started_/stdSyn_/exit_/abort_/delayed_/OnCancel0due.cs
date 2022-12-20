using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.nonshell_.nonwin_.redirStd_.redirErr.proc_.errAsyn_.started_.stdSyn_.exit_.abort_.delayed_
{
	public class OnDue0cancel
		: StdSyn

	{
		public OnDue0cancel(RedirErr info
			,
			int? life
			,
			CancellationToken cancellationToken
			, int? runAftCancel = null, int? closing = null, int? wait = null

		) : base(
				info


		)
		{
			_end( life, cancellationToken, runAftCancel, closing, wait);
		}
		public OnDue0cancel(
			RedirStd info
			,
			int? life
			,
			CancellationToken cancellationToken
			, int? runAftCancel = null, int? closing = null, int? wait = null
		) : this(
			new RedirErr(info), life, cancellationToken, runAftCancel, closing, wait

		)
		{
		}

		public OnDue0cancel(Nonshell val    ,     int? life
			,
			CancellationToken cancellationToken
			, int? runAftCancel = null, int? closing = null, int? wait = null


		) : this(
			new RedirStd(val)
			, life, cancellationToken, runAftCancel, closing, wait

			)

		{
		}


		public OnDue0cancel(PrepI val,
			int? life
			,
			CancellationToken cancellationToken
			, int? runAftCancel = null, int? closing = null, int? wait = null

) : this(
			new Nonshell(val), life, cancellationToken, runAftCancel, closing, wait


			)
		{
		}
		public OnDue0cancel(PrepA val,
			int? life
			,
			CancellationToken cancellationToken
			, int? runAftCancel = null, int? closing = null, int? wait = null
		) : this(
			(PrepI)(val)
			, life, cancellationToken, runAftCancel, closing, wait

			)
		{
		}
		public OnDue0cancel(ProcessStartInfo val
			,
			int? life
			,
			CancellationToken cancellationToken
			, int? runAftCancel = null, int? closing = null, int? wait = null
			) : this(
			new Nonshell(val), life, cancellationToken, runAftCancel, closing, wait

		)
		{
		}


		public OnDue0cancel(string cmd, string arg , string dir
			,
			int? life
			,
			CancellationToken cancellationToken
			, int? runAftCancel = null, int? closing = null, int? wait = null

) :
			this(
			new prog.Prep(cmd, arg, dir), life, cancellationToken, runAftCancel, closing, wait

		)
		{
		}

		public OnDue0cancel(string cmd, string arg, ShieldI dir
			,
			int? life
			,
			CancellationToken cancellationToken
			, int? runAftCancel = null, int? closing = null, int? wait = null
) :
				this(
			new prog.Prep(cmd, arg, dir), life, cancellationToken, runAftCancel, closing, wait

		)

		{
		}

		public OnDue0cancel(string cmd, string arg, FolderI dir
			,
			int? life
			,
			CancellationToken cancellationToken
			, int? runAftCancel = null, int? closing = null, int? wait = null
) :
				this(
			new prog.Prep(cmd, arg, dir), life, cancellationToken, runAftCancel, closing, wait

		)
		{
		}




		private void _end(int? life, CancellationToken cancellationToken,int? runAftCancel=null, int? closing=null, int? wait=null)
		{

			os.proc_.started.abort_.delayed_.onDue0cancel_._ThrowQuitTimeoutX.Vod(
				boxed
				,
				life
				,
				cancellationToken
				,
				runAftCancel
				,

				closing
				,
				wait
			);
			// To avoid deadlocks, always read the output stream first and then wait.  

			//return new nilnul.os.proc_.finished._result.CodMsgErr(boxed.ExitCode, r, this.err);

		}
		public os.proc_.finished._result.CodMsgErr result
		{

			get
			{
				return new os.proc_.finished._result.CodMsgErr(boxed.ExitCode, base.msg, base.err);

			}


		}


	}
}
