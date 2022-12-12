using nilnul.os._proc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.waited

{
	/// <summary>
	/// norm the window before inact1min it;
	/// </summary>
	static public class _CodX
	{
		public static int Cod(PrepI timeout, int? lurk=null)
		{
			using (var p = new Waited(timeout,lurk )
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
