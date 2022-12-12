using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;




namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started_.invis_.defer_
;   /// <summary>
	/// bottom
	/// inactive min
	/// and titled
	/// </summary>
public class Loom : Invis
{
	//public Started(Started started) : base(started)
	//{
	//}
	//public Started(ErrAsyn started) : base(started)
	//{
	//	boxed.Start();
	//}
	public Loom(nilnul.os.prog.prep_.shell_.win_.Min info, int? delay = null, CancellationToken cancel = default) : base(
		(info)
	)
	{
		var c = cancel;
		//os.ui.act_.bottom_.normal_.inact1min_.title.traceXpn._DelayX.Task(
		//	base.ui
		//	, null

		//	, delay,
		//	cancel
		//);
		
		started.ui_.invis.act_.bottom_.inact1min_.title.traceXpn._DelayX.Task(
			boxed
			, null

			, delay,
			cancel
		);

		//os.proc_.started_.ui_.nonnil.act_.bottom_.inact1min_.title.traceXpn._DelayX.Task(
		//	boxed
		//	, null
		//	,
		//	cancel
		//	, delay
		//);

		//Task.Delay(
		//	delay?? nilnul.os.Properties.Settings.Default.procLaterPop, c).ContinueWith(
		//	(t)=>nilnul.os.proc.act_.ui_._BotPopTitleX.Act(boxed)
		//	,c
		//);



	}


	public Loom(nilnul.os.prog.prep_.shell_.Win info, int? delay = null, CancellationToken cancel = default) : this(
		new prog.prep_.shell_.win_.Min(info)
		, delay, cancel
	)
	{
	}

	//public PopTitleDelay(End info):base(info)
	//		{
	//		}

	public Loom(prog.prep_.Shell val, int? delay = null, CancellationToken cancel = default) : this(new prog.prep_.shell_.Win(val), delay, cancel)
	{
	}

	public Loom(ProcessStartInfo val, int? delay = null, CancellationToken cancel = default) : this(new prog.prep_.Shell(val), delay, cancel)
	{
	}

	public Loom(PrepI prep, int? delay = null, CancellationToken cancel = default) : this(new prog.prep_.Shell(prep), delay, cancel)
	{
	}

	public Loom(PrepA prep, int? delay = null, CancellationToken cancel = default) : this((PrepI)(prep), delay, cancel)
	{
	}

	public Loom(Prep prep, int? delay = null, CancellationToken cancel = default) : this((PrepI)(prep), delay, cancel)
	{
	}

	public Loom(string cmd, string arg = null, string dir = null, int? delay = null, CancellationToken cancel = default) : this(
		new prog.Prep(
		cmd, arg, dir
		), delay, cancel
	)
	{
	}

	public Loom(string cmd, string arg = null, ShieldI dir = null, int? delay = null, CancellationToken cancel = default) : this(
		cmd, arg, dir?.ToString(), delay, cancel
		)
	{
	}

	public Loom(string cmd, string arg = null, FolderI dir = null, int? delay = null, CancellationToken cancel = default) : this(
		cmd, arg, dir?.ToString(), delay, cancel
	)
	{
	}


}

