using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;




namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_
{
	/// <summary>
	/// reshow
	/// </summary>
	///
	[Obsolete("set title not work if normalizing step is ommited;")]

	public class Loom_byNoNormal : Started
	{
		private Task _task;

		public Task task
		{
			get { return _task; }
			set { _task = value; }
		}

		//public Started(Started started) : base(started)
		//{
		//}
		//public Started(ErrAsyn started) : base(started)
		//{
		//	boxed.Start();
		//}
		public Loom_byNoNormal(win_.Hid  info, int? delay=null, CancellationToken  cancel=default)
			:
		base(
			info
		)
		{
			//info.info.WindowStyle = ProcessWindowStyle.Minimized; // no effect?


			///hold the task lest it be disposed--- or maybe this is not necessary as the task is now already held in scheduler
			///
#if Symbol
			Debug.WriteLine("lurking...");

#endif

			//nilnul.os.proc_.mainWinFreshed.act_.bottom_.show_.title.traceXpn._DelayX.Task(
			//	boxed
			//	, null
			//	,
			//	cancel
			//	, delay

			//);


			//_task = nilnul.os.ui.act_.bottom_.normal_.inact1min_.title.traceXpn._DelayX.Task(
			//	base.ui, null,cancel, delay
			//);
			_task = nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui.act_.bottom_.inact1min_.title.traceXpn._DelayX.Task(
				boxed, null, cancel, delay
			);

		}

		public Loom_byNoNormal(ProcessStartInfo val, int? delay=null, CancellationToken  cancel=default)
			: this(
			new win_.Hid(val), delay,cancel
		)
		{
		}

		public Loom_byNoNormal(PrepI prep, int? delay=null, CancellationToken  cancel=default)
			:
			this(new win_.Hid(prep), delay,cancel)
		{
		}

		public Loom_byNoNormal(PrepA prep, int? delay=null, CancellationToken  cancel=default)
			: this((PrepI)(prep), delay,cancel)
		{
		}

		public Loom_byNoNormal(Prep prep, int? delay=null, CancellationToken  cancel=default)
			: this((PrepI)(prep), delay,cancel)
		{
		}

		public Loom_byNoNormal(string cmd, string arg = null, string dir = null, int? delay=null, CancellationToken  cancel=default)
			: this(
			new Prep(
			cmd, arg, dir
			), delay,cancel
		)
		{
		}

		public Loom_byNoNormal(string cmd, string arg = null, ShieldI dir = null, int? delay=null, CancellationToken  cancel=default)
			: this(
			cmd, arg, dir?.ToString(), delay,cancel
			)
		{
		}

		public Loom_byNoNormal(string cmd, string arg = null, FolderI dir = null, int? delay=null, CancellationToken  cancel=default)
			:
			this(
			cmd, arg, dir?.ToString(), delay,cancel
		)
		{
		}

		
	}
}
