using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.started_.stdSyn_.exit_.abort_
{
	public class OnCancel
		: StdSyn

	{
		public OnCancel(nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info
			,
			CancellationToken cancellationToken, int? closing = null, int? wait = null

		) : base(
				info


		)
		{
			_end( cancellationToken,closing,wait);
		}
		public OnCancel(
			nilnul.os.prog.prep_.nonshell_.RedirStd info
,CancellationToken cancellationToken, int? closing = null, int? wait = null
		) : this(
			new prog.prep_.nonshell_.redirStd_.RedirErr(info),cancellationToken,closing,wait

		)
		{
		}

		public OnCancel(prog.prep_.Nonshell val,CancellationToken cancellationToken, int? closing = null, int? wait = null

		) : this(
			new prog.prep_.nonshell_.RedirStd(val)
			,cancellationToken,closing,wait

			)

		{
		}


		public OnCancel(PrepI val
,CancellationToken cancellationToken, int? closing = null, int? wait = null

) : this(
			new prog.prep_.Nonshell(val), cancellationToken, closing, wait


			)
		{
		}
		public OnCancel(PrepA val, CancellationToken cancellationToken, int? closing = null, int? wait = null) : this(
			(PrepI)(val)
			, cancellationToken, closing, wait

			)
		{
		}
		public OnCancel(ProcessStartInfo val, CancellationToken cancellationToken, int? closing = null, int? wait = null) : this(
			new prog.prep_.Nonshell(val), cancellationToken, closing, wait

		)
		{
		}


		public OnCancel(string cmd, string arg , string dir ,CancellationToken cancellationToken, int? closing = null, int? wait = null

) :
			this(
			new prog.Prep(cmd, arg, dir), cancellationToken, closing, wait

		)
		{
		}

		public OnCancel(string cmd, string arg, ShieldI dir, CancellationToken cancellationToken, int? closing = null, int? wait = null
) :
				this(
			new prog.Prep(cmd, arg, dir), cancellationToken

		)

		{
		}

		public OnCancel(string cmd, string arg, FolderI dir, CancellationToken cancellationToken, int? closing = null, int? wait = null
) :
				this(
			new prog.Prep(cmd, arg, dir), cancellationToken, closing, wait

		)
		{
		}




		private void _end(CancellationToken cancellationToken, int? closing=null, int? wait=null)
		{

			os.proc_.started.abort_.throwKilling_._OnCancelX.Vod(
				boxed
				,
				cancellationToken
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
