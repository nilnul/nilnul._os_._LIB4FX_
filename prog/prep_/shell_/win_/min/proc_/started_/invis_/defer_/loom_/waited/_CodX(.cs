using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started_.invis_.defer_.loom_.waited

{
	static public class _CodX
	{
		static public  int OfAddress(string cmd, string arg = null, string dir = null, int? lurk=null)
		{
			using (var p = new Waited(cmd,arg,dir,lurk)
			)
			{
				return p.cod;
			}
		}

		public static int Cod(prog.PrepI timeout, int? lurk=null)
		{
			using (var p = new Waited(timeout,lurk )
			)
			{
				return p.cod;
			}

		}
	}
}
