
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started_.invis_.defer_.loom_
{
	public class Waited : Loom
	{
		//private int? _life;

		//public int? life
		//{
		//	get { return _life; }
		//	set { _life = value; }
		//}

		//private int? _bye;

		//public int? bye
		//{
		//	get { return _bye; }
		//	set { _bye = value; }
		//}

		private CancellationTokenSource _cancelSrc;

		public CancellationTokenSource cancelSrc
		{
			get { return _cancelSrc; }
			set { _cancelSrc = value; }
		}

		//public End(End info) : base(
		//	info
		//)
		//{
		//	_cancelSrc = info.cancelSrc;
		//}

		//public End(Timeout info, CancellationTokenSource cancelSrc, int? life=null, int? bye=null) : base(

		//	info,cancelSrc.Token,life,bye
		//)
		//{

		//}


		//public End(UnExited info, CancellationTokenSource cancelSrc, int? life = null, int? bye = null) : base(

		//	new Timeout(info, cancelSrc.Token,life,bye)
		//)
		//{
		//	_cancelSrc = cancelSrc;
		//	end();

		//}

		public Waited(ProcessStartInfo info, int? life , CancellationTokenSource cancelSrc) : base(

			info, life, cancelSrc.Token
		)
		{
			_cancelSrc = cancelSrc;
			end();

		}

		public Waited(ProcessStartInfo info, int? life = null) : this(
			(info),life, new CancellationTokenSource()
		)
		{

		}


		public Waited(PrepI info,  int? life = null) : this(
			info.info, life
		)
		{

		}
		public Waited(PrepA info,  int? life = null) : this(
			(PrepI)info,  life
		)
		{

		}

		public Waited(string cmd, string arg, string dir, int? life = null):this(new nilnul.os.prog.Prep( cmd,arg,dir), life)
		{
		}

		public void end() {
			boxed.WaitForExit();
			_cancelSrc.Cancel();
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
