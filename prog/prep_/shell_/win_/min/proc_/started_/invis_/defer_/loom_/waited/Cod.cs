using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started_.invis_.defer_.loom_.waited

{
	public class Cod : nilnul.os.prog.run_.exit.CodA 
	{
		private int _lurk;

		public int lurk
		{
			get { return _lurk; }
			set { _lurk = value; }
		}

		public Cod(int lurk)
		{
			_lurk = lurk;
		}
		public Cod():this( nilnul.os.Properties.Settings.Default.procLaterPop)
		{
		}

		public override int ofAddress(string cmd, string arg = null, string dir = null)
		{
			return _CodX.OfAddress(cmd, arg, dir);
		}

		static public Cod Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cod>.Instance;
			}
		}

	}
}
