using nilnul.os._proc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.waited

{
	[Obsolete("set title not work if normalizing step is ommited;")]

	public class Cod_byNoNorm : nilnul.os.prog.run_.exit.CodA
	{
		private int _lurk;

		public int lurk
		{
			get { return _lurk; }
			set { _lurk = value; }
		}

		public Cod_byNoNorm(uint lurk) {
			_lurk = (int)lurk;
		}

		public Cod_byNoNorm(int lurk):this((uint)lurk)
		{
		}

		public Cod_byNoNorm(int? lurk):this(
			os.Properties.SettingsX._Lurk(lurk)
		)
		{

		}
		
		public Cod_byNoNorm():this( nilnul.os.Properties.Settings.Default.procLaterPop)
		{
		}

		public override int ofAddress(string cmd, string arg = null, string dir = null)
		{
			return _CodX_byNoNorm.OfAddress(cmd, arg, dir, _lurk);
		}

		public  int cod(PrepI timeout, int? lurk = null)
		{
			using (var p = new Waited_byNoNormal(timeout, lurk)
			)
			{
				return p.cod;
			}

		}





		static public Cod_byNoNorm Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Cod_byNoNorm>.Instance;
			}
		}






		static public Cod_byNoNorm Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cod_byNoNorm>.Instance;
			}
		}


	}
}
