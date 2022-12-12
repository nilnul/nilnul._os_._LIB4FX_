
using nilnul.os.prog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.doodle_
{
	public class Wait : Doodle
	{
		

		private CancellationTokenSource _cancelSrc;

		public CancellationTokenSource cancelSrc
		{
			get { return _cancelSrc; }
			set { _cancelSrc = value; }
		}

		public Wait(Wait info) : base(
			info
		)
		{
			_cancelSrc = info.cancelSrc;
		}

	


		private Wait(Started info, CancellationTokenSource cancelSrc, int? life = null, int? bye = null) : base(

			new Doodle(info, cancelSrc.Token,life,bye)
		)
		{
			_cancelSrc = cancelSrc;
			end();

		}


		public Wait(ProcessStartInfo info, int? life = null, int? bye = null) : this(
			new Started(info),new CancellationTokenSource(),life,bye
		)
		{

		}
		public Wait(os.prog.PrepI info,  int? life = null, int? bye = null) : this(
			info.info, life,bye
		)
		{

		}
		public Wait(os.prog.PrepA info,  int? life = null, int? bye = null) : this(
			(PrepI)info,  life,bye
		)
		{

		}

		//public Wait(PrepI info,  int? life = null, int? bye = null) : this(
		//	info.info, life,bye
		//)
		//{

		//}
		//public Wait(PrepA info,  int? life = null, int? bye = null) : this(
		//	(PrepI)info,  life,bye
		//)
		//{

		//}

		public Wait(string cmd, string arg, string dir, int? life = null, int? bye = null):this(new nilnul.os.prog.Prep( cmd,arg,dir), life,bye)
		{
		}

		public void end() {

			//base.killTask.Wait();  // wait for the kill task.
			//no, don't wait, or the delay of 5 minutes will make you wait for 5 minutes even if you proc is ended early. the task out there running parallely means it's doodling in the first 5 minutes, and we cancel the task, in the next line.

			boxed.WaitForExit();

			_cancelSrc.Cancel();
			_cancelSrc.Dispose();
		}

		public int cod
		{
			get
			{

				return boxed.ExitCode;
			}
		}





	}
}
