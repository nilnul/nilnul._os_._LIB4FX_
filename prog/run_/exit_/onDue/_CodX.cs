using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit_.onDue
{
	/// <summary>
	/// </summary>
	public class _CodX
	{
		public static int Cod(string cmd, string arg, string dir, int? lurk=null,int? life = null, int? bye = null,int? waitAftKill=null)
		{
			return  prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.exit_.onDue._CodX._ExitCode(cmd,arg,dir
				,
				lurk
				,
				life, bye
				,waitAftKill
			);

			//return Cod.Singleton.cod(
			//	new Prep(cmd,arg,dir),life,bye
			//);

			
		}

		public static int Cod(PrepI prep, int? lurk = null, int? life = null, int? bye = null, int? waitAftKill = null)
		{
			return  prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.exit_.onDue._CodX._ExitCode(
				prep
				,
				lurk,
				life, bye
				,
				waitAftKill
			);

		}
	}

	
}
