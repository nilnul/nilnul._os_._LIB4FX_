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
	public class OnCancel
		: StdSyn

	{
		public OnCancel(RedirErr info
			,
			CancellationToken cancellationToken
			, int? runAftCancel = null, int? closing = null, int? wait = null

		) : base(
				info


		)
		{
			_end( cancellationToken,runAftCancel,closing,wait);
		}
		public OnCancel(
			RedirStd info
,CancellationToken cancellationToken, int? runAftCancel = null, int? closing = null, int? wait = null
		) : this(
			new RedirErr(info),cancellationToken, runAftCancel, closing, wait

		)
		{
		}

		public OnCancel(Nonshell val,CancellationToken cancellationToken, int? runAftCancel = null, int? closing = null, int? wait = null

		) : this(
			new RedirStd(val)
			,cancellationToken, runAftCancel, closing, wait

			)

		{
		}


		public OnCancel(PrepI val
,CancellationToken cancellationToken, int? runAftCancel = null, int? closing = null, int? wait = null

) : this(
			new Nonshell(val), cancellationToken, runAftCancel, closing, wait


			)
		{
		}
		public OnCancel(PrepA val, CancellationToken cancellationToken, int? runAftCancel = null, int? closing = null, int? wait = null) : this(
			(PrepI)(val)
			, cancellationToken, runAftCancel, closing, wait

			)
		{
		}
		public OnCancel(ProcessStartInfo val, CancellationToken cancellationToken, int? runAftCancel = null, int? closing = null, int? wait = null) : this(
			new prog.prep_.Nonshell(val), cancellationToken, runAftCancel, closing, wait

		)
		{
		}


		public OnCancel(string cmd, string arg , string dir ,CancellationToken cancellationToken, int? runAftCancel = null, int? closing = null, int? wait = null

) :
			this(new prog.Prep(cmd, arg, dir), cancellationToken, runAftCancel, closing, wait)
		{
		}

		public OnCancel(string cmd, string arg, ShieldI dir, CancellationToken cancellationToken, int? runAftCancel = null, int? closing = null, int? wait = null
) :
				this(new prog.Prep(cmd, arg, dir), cancellationToken, runAftCancel, closing, wait)

		{
		}

		public OnCancel(string cmd, string arg, FolderI dir, CancellationToken cancellationToken, int? runAftCancel = null, int? closing = null, int? wait = null
) :
				this(new prog.Prep(cmd, arg, dir), cancellationToken, runAftCancel, closing, wait)
		{
		}




		private void _end(CancellationToken cancellationToken,int? runAftCancel=null, int? closing=null, int? wait=null)
		{

			os.proc_.started.abort_.delayed_.onCancel_._ThrowQuitTimeoutX.Vod(
				boxed
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
