﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;




namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_
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

		public Started(nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info) : base(
			(info)
		)
		{
			

			boxed.Start();
			boxed.BeginErrorReadLine();
		}


		public Started(nilnul.os.prog.prep_.nonshell_.RedirStd info) : this(
			new prog.prep_.nonshell_.redirStd_.RedirErr(info)
		)
		{
		}



		public Started(prog.prep_.Nonshell val) : this(new prog.prep_.nonshell_.RedirStd(val))
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
