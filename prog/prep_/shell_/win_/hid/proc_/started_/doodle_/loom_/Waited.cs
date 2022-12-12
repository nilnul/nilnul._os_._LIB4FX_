
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_
{
	public class Waited : Loom
	{
	

		private CancellationTokenSource _cancelSrc;

		public CancellationTokenSource cancelSrc
		{
			get { return _cancelSrc; }
			set { _cancelSrc = value; }
		}

		private Waited(win_.Hid info, int? life , CancellationTokenSource cancelSrc)
			: base(
			(info),life,cancelSrc.Token
		)
		{
			_cancelSrc = cancelSrc;
			end();

		}
		public Waited(win_.Hid info, int? life = null) : this(
			(info),life,new CancellationTokenSource()
		)
		{

		}
		public Waited(shell_.Win info, int? life , CancellationTokenSource cancelSrc) : this(
			new win_.Hid(
				info
			)
			, life, cancelSrc
		)
		{

		}
		public Waited(shell_.Win info, int? life = null) : this(
			new win_.Hid(info),life
		)
		{

		}

		public Waited(Shell info, int? life , CancellationTokenSource cancelSrc) : this(
			new shell_.Win(
				info
			)
			, life, cancelSrc
		)
		{

		}
	
		public Waited(Shell  info, int? life = null) : this(
			new Win(info),life
		)
		{

		}

		public Waited(ProcessStartInfo info, int? life , CancellationTokenSource cancelSrc) : this(
			new Shell(
				info
			)
			, life, cancelSrc
		)
		{

		}



		public Waited(ProcessStartInfo info, int? life = null) : this(
			new Shell	(info),life
		)
		{

		}



		public Waited(PrepI info,  int? life = null)
			: this(
			info.info, life
		)
		{

		}
		public Waited(PrepA info,  int? life = null) : this(
			(PrepI)info,  life
		)
		{

		}

		public Waited(string cmd, string arg, string dir, int? life = null):this(new Prep( cmd,arg,dir), life)
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
