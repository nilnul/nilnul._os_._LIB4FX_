using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.exit_.throwKilling_
{
	/// <summary>
	///  on due or cancel; the loomAftLurk
	/// </summary>
	public class OnDue0cancel
		: Loom
	{

		private CancellationTokenSource _cancelSrc4Lurk;

		public CancellationTokenSource cancelSrc4Lurk
		{
			get { return _cancelSrc4Lurk; }
			set { _cancelSrc4Lurk = value; }
		}

		private OnDue0cancel(
			nilnul.os.prog.prep_.shell_.win_.Min info
			, int? lurk
			, CancellationTokenSource lurk_cancelSrc
			, int? loomAftLurk = null
			, int? bye = null
			, int? waitAftKill = null
		) : base(

				info
				, lurk
				,
				lurk_cancelSrc.Token
		)
		{
			_cancelSrc4Lurk = lurk_cancelSrc;

			//int life ;
			//if (loomAftLurk is null)
			//{
			//	life= os.Properties.SettingsX._Life4proc() ;
			//}
			//else
			//{
			//	life = os.Properties.SettingsX._Lurk(lurk) + loomAftLurk.Value;
			//}

			_end(
				lurk_cancelSrc
				,
				loomAftLurk is null? os.Properties.SettingsX._Life4proc() : (os.Properties.SettingsX._Lurk(lurk) + loomAftLurk.Value)
				
				,
				bye
				,
				waitAftKill
			);
		}


		public OnDue0cancel(nilnul.os.prog.prep_.shell_.win_.Min info
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


		public OnDue0cancel(Win val
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

		public OnDue0cancel(Shell val
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


		public OnDue0cancel(PrepI val
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
		public OnDue0cancel(PrepA val,
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


		public OnDue0cancel(Prep val
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
		public OnDue0cancel(ProcessStartInfo val
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

		public OnDue0cancel(string cmd, string arg = null, string dir = null,
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

		public OnDue0cancel(string cmd, string arg, ShieldI dir,
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

		public OnDue0cancel(string cmd, string arg, FolderI dir,
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
			Trace.TraceInformation("aborting...");

			
			os.proc_.started.abort_.throwKilling_._OnDueX.Vod(
					boxed
					,
					life
					,

					bye
					,
					waitAftKill
			);

			Trace.TraceInformation("cancelling lurk");

			cancelSrc.Cancel();
			Trace.TraceInformation("let out task exception");






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

		public static OnDue0cancel InSeconds(ProcessStartInfo timeout, int? life = null, int? bye = null, int? aftKill = null)
		{
			return new OnDue0cancel(
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
