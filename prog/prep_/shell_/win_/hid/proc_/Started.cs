﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;




namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_
{
	public class Started : Proc
	{

		public Started(prep_.shell_.win_.Hid info) : base(
				(info)
			)
		{
			boxed.Start();
		}

		public Started(prep_.shell_.Win info) : this(new Hid
			(info)
		)
		{
		}

		public Started(prep_.Shell val) : this(new prep_.shell_.Win(val))
		{
		}
		public Started(PrepI prep) : this(new prep_.Shell(prep))
		{
		}
		public Started(PrepA prep) : this((PrepI)(prep))
		{
		}

		public Started(ProcessStartInfo val) : this(new Prep(val))
		{
		}


	

		public Started(string cmd, string arg = null, string dir = null) : this(
			new Prep(
			cmd, arg, dir
			)
		)
		{
		}

		public Started(string cmd, string arg, ShieldI dir) : this(
			new Prep(
			cmd, arg, dir
			)
			)
		{
		}

		public Started(string cmd, string arg, FolderI dir) : this(
			new Prep(
			cmd, arg, dir
			)
			)

		{
		}
		public Started(string cmd) : this(new Prep(cmd))

		{
		}

	}
}
