
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_.min.proc_.errAsyn_.started_
{
	public class OnDue0cancel : Started
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="cancel"></param>
		/// <param name="life"></param>
		/// <param name="bye"></param>
		/// <param name="waitAftKill">obsoleted</param>
		public OnDue0cancel(
			nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info
			, int? life = null
			, int? bye = null
			, int? waitAftKill = null
			, CancellationToken cancel = default

		) : base(
			info
		)
		{

			_timeout(life, bye, waitAftKill,cancel);

		}

		public OnDue0cancel(
			ProcessStartInfo info, int? life = null, int? bye = null,int? wait=null, CancellationToken cancel=default
		)
			:
			this(
			new os.prog.prep_.nonshell_.redirStd_.RedirErr(info), life, bye,wait, cancel
		)
		{
		}

		public OnDue0cancel(
			PrepI info
			, int? life = null
			, int? bye = null
			,
			int? wait=null
			, CancellationToken cancel=default
		) : this(
			info.info, life, bye,wait, cancel
		)
		{

		}
		public OnDue0cancel(PrepA info, int? life = null, int? bye = null,int? wait=null, CancellationToken cancel=default)
			: this(
			(PrepI)info, life, bye,wait,cancel
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
		private void _timeout( int? life = null, int? bye = null, int? waitAftKill = null,CancellationToken cancel = default)
		{
			//this.cancel = cancel;
			_task = os.proc_.started.cull_.onDue0cancel_.onStaticCancel_._CancellableX.AsTask(
				boxed,
				life,bye,waitAftKill, cancel
			);


			//var cancelSrc = new CancellationTokenSource();

			//var task = started.act_.die.traceXpn.kill._DelayX.Task(boxed, cancelSrc.Token, life, bye); 
			//boxed.WaitForExit(); 
			//cancelSrc.Cancel();


		}

	}
}
