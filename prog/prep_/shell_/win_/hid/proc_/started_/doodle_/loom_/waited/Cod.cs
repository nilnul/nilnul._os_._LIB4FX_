using nilnul.os._proc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.waited

{
	public class Cod : nilnul.os.prog.run_.exit.CodA
	{
		private int _lurk;

		public int lurk
		{
			get { return _lurk; }
			set { _lurk = value; }
		}

		public Cod(uint lurk) {
			_lurk = (int)lurk;
		}

		public Cod(int lurk):this((uint)lurk)
		{
		}

		public Cod(int? lurk):this(
			os.Properties.SettingsX._Lurk(lurk)
		)
		{

		}
		
		public Cod():this( nilnul.os.Properties.Settings.Default.procLaterPop)
		{
		}

		public override int ofAddress(string cmd, string arg = null, string dir = null)
		{
			return _CodX.OfAddress(cmd, arg, dir, _lurk);
		}

		public  int cod(PrepI timeout, int? lurk = null)
		{
			using (var p = new Waited(timeout, lurk)
			)
			{
				return p.cod;
			}

		}





		static public Cod Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Cod>.Instance;
			}
		}






		static public Cod Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cod>.Instance;
			}
		}


	}
}
