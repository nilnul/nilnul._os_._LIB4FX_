
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_.min.proc_.errAsyn_.started_
{
	public class Timed : Started

	{
		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="cancel"></param>
		/// <param name="life"></param>
		/// <param name="bye"></param>
		/// <param name="waitAftKill">obsoleted</param>
		public Timed(nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info, CancellationToken cancel = default, int? life = null, int? bye = null, int? waitAftKill = null) : base(
			info
		)
		{

			_timeout(cancel, life, bye, waitAftKill);

		}

		public Timed(ProcessStartInfo info, CancellationToken cancel, int? life = null, int? bye = null) : this(
			new os.prog.prep_.nonshell_.redirStd_.RedirErr(info), cancel, life, bye
		)
		{
		}

		public Timed(PrepI info, CancellationToken cancel, int? life = null, int? bye = null) : this(
			info.info, cancel, life, bye
		)
		{

		}
		public Timed(PrepA info, CancellationToken cancel, int? life = null, int? bye = null) : this(
			(PrepI)info, cancel, life, bye
		)
		{

		}

		private Task _task;

		public Task task
		{
			get { return _task; }
			set { _task = value; }
		}

		//private CancellationToken _cancel;

		//public CancellationToken cancel
		//{
		//	get { return _cancel; }
		//	set { _cancel = value; }
		//}

		//public void cancel() {

		//}
		private void _timeout(CancellationToken cancel = default, int? life = null, int? bye = null, int? waitAftKill = null)
		{
			//this.cancel = cancel;
			_task = os.proc_.started.cull_.delayed_._CancellableX._Exit0cancelledAsTask(
				boxed,
				life,bye, cancel
			);


			//var cancelSrc = new CancellationTokenSource();

			//var task = started.act_.die.traceXpn.kill._DelayX.Task(boxed, cancelSrc.Token, life, bye); 
			//boxed.WaitForExit(); 
			//cancelSrc.Cancel();


		}

	}
}
