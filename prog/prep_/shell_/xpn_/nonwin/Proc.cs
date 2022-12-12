using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;




namespace nilnul.os.prog.prep_.shell_.nonwin
{
	public class Proc :os.Proc
	{

		public Proc(prep_.shell_.Nonwin info) : base(
			(info)
		)
		{
		}

		public Proc(prep_.Shell val) : this(new prep_.shell_.Nonwin(val))
		{
		}
		public Proc(PrepI prep) : this(new prep_.Shell(prep))
		{
		}
		public Proc(PrepA prep) : this((PrepI)(prep))
		{
		}

		public Proc(ProcessStartInfo val) : this(new Prep(val))
		{
		}


		public Proc(string cmd, string arg = null, string dir = null) : this(
			new Prep(
			cmd, arg, dir
			)
		)
		{
		}

		public Proc(string cmd, string arg, ShieldI dir) : this(
			
			cmd, arg, dir.ToString()
			
			)
		{
		}

		public Proc(string cmd, string arg, FolderI dir) : this(
			cmd, arg, dir.address.en
			
			)

		{
		}
	}
}
