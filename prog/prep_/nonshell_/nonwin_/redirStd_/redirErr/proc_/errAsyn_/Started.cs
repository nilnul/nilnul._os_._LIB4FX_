using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;




namespace nilnul.os.prog.prep_.nonshell_.nonwin_.redirStd_.redirErr.proc_.errAsyn_
{
	/// <summary>
	/// begin reading err
	/// </summary>
	public class Started : ErrAsyn
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
			boxed.BeginErrorReadLine();
		}


		public Started(RedirStd info) : this(
			new RedirErr(info)
		)
		{
		}

		public Started(Nonwin val) : this(new RedirStd(val))
		{
		}

		public Started(Nonshell val) : this(new Nonwin(val))
		{
		}

		public Started(PrepI prep) : this(new Nonshell(prep))
		{
		}

		public Started(ProcessStartInfo val) : this(new Nonshell(val))
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
