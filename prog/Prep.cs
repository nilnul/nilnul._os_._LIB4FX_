using System.Collections.Generic;
using System.Diagnostics;
using nilnul.fs;
using nilnul.fs.address_;

namespace nilnul.os.prog
{
	public class Prep :
		PrepA
		,
		PrepI
	{

		public Prep(ProcessStartInfo val) : base(val)
		{
		}
		public Prep():this(new ProcessStartInfo())
		{
		}

		public Prep(string cmd, string arg = null, string dir = null) : base(cmd, arg, dir)
		{


		}

		public Prep(string cmd, IEnumerable<string> arg = null, string dir = null) : base(cmd, arg, dir)
		{


		}

		public Prep(string cmd, string arg, ShieldI dir) : base(cmd, arg, dir)
		{
		}

		public Prep(string cmd, string arg, FolderI dir) : base(cmd, arg, dir)
		{
		}

		public Prep(PrepI prep):base(prep)
		{
		}

		protected Prep(PrepA prep) : this((PrepI)prep)
		{
		}

	}
}
