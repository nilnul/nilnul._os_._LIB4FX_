using nilnul.win.prog._run;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.win.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_
{
	/// <summary>
	/// abort the process: if it's running, kill it;
	/// </summary>
	public class Abortable : Started

	{

		private int? _minimum4usr2close;

		public int? minimum4usr2close
		{
			get { return _minimum4usr2close; }
			set { _minimum4usr2close = value; }
		}

		//private int? _extended4usr2close;

		//public int? extended4usr2close
		//{
		//	get { return _extended4usr2close; }
		//	set { _extended4usr2close = value; }
		//}

		private int? _waitAftKilling;

		public int? waitAftKilling
		{
			get { return _waitAftKilling; }
			set { _waitAftKilling = value; }
		}


		public Abortable(
			RedirErr info,   int? minimum4usr2close=null
			,  int? waitAftKilling = null

			) : base(
			info
		)
		{
			_minimum4usr2close = minimum4usr2close;
			_waitAftKilling = waitAftKilling;



		}


		public Abortable(ProcessStartInfo info,  int? minimum4usr2close=null
			,  int? waitAftKilling = null

			) : this(
			new RedirErr(info), minimum4usr2close,  waitAftKilling
		)
		{
	}

		public Abortable(PrepI info,   int? minimum4usr2close= null,  int? waitAftKilling = null
) : this(
			info.info, minimum4usr2close,  waitAftKilling
		)
		{

		}
		public Abortable(PrepA info,   int? minimum4usr2close= null,  int? waitAftKilling = null
) : this(
			(PrepI)info, minimum4usr2close,  waitAftKilling
		)
		{

		}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="minimum4usr2close"></param>
	/// <param name="waitAftKilling"></param>
	/// <exception cref="">
	/// if the process doesnot respond to Wait; or wait too long
	/// </exception>
		public void _end(
			int? minimum4usr2close = null,  int? waitAftKilling = null
)
		{

			 os.proc_.started.end_._CancelableX._Vod(
				boxed,   minimum4usr2close,  waitAftKilling
			).Wait();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cancel">
		/// useless as this par is used to cancel extra delay but we have no extra delay: due, and extended4usr2close
		/// </param>
		public void _end(
)
		{
			_end(
				
				this._minimum4usr2close

				,
				this._waitAftKilling
			);
		}




	}
}
