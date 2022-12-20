using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;




namespace nilnul.os.prog.prep_.nonshell_.nonwin_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_
{
	/// <summary>
	/// begin reading err
	/// </summary>
	public class Started : StdAsyn
	{
		//public Started(Started started) : base(started)
		//{
		//}
		//public Started(ErrAsyn started) : base(started)
		//{
		//	boxed.Start();
		//}

		public Started(RedirErr info) : base(
			(info)
		)
		{
			

			boxed.Start();
			boxed.BeginOutputReadLine();
			boxed.BeginErrorReadLine();//When asynchronous read operations start, the event handler is called each time the associated Process writes a line of text to its StandardError stream.

		}


		public Started(RedirStd info) : this(
			new RedirErr(info)
		)
		{
		}


		public Started(prog.prep_.nonshell_.Nonwin val) : this(new prog.prep_.nonshell_.nonwin_.RedirStd(val))
		{
		}

		public Started(prog.prep_.Nonshell val) : this(new prog.prep_.nonshell_.Nonwin(val))
		{
		}


		public Started(PrepI prep) : this(new prog.prep_.Nonshell(prep))
		{
		}

		public Started(ProcessStartInfo val) : this(new prog.prep_.Nonshell(val))
		{
		}


		public Started(string cmd, string arg = null, string dir = null) : this(
			new prog.Prep(
			cmd, arg, dir
			)
		)
		{
		}

		public Started(string cmd, string arg, ShieldI dir) : this(
			new prog.Prep(
			cmd, arg, dir
			)
			)
		{
		}

		public Started(string cmd, string arg, FolderI dir) : this(
			new prog.Prep(
			cmd, arg, dir
			)
			)

		{
		}


	}
}
