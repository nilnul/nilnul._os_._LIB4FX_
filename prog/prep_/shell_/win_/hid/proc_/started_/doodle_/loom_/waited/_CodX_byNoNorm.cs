using nilnul.os._proc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.waited

{
	[Obsolete("set title not work if normalizing step is ommited;")]
	static public class _CodX_byNoNorm
	{
		public static int Cod(PrepI timeout, int? lurk=null)
		{
			using (var p = new Waited_byNoNormal(timeout,lurk )
			)
			{
				return p.cod;
			}

		}
		static public  int OfAddress(string cmd, string arg = null, string dir = null, int? lurk=null)
		{
			return Cod(
				new Prep(cmd,arg,dir)
				,
				lurk
			);
		}

	}
}
