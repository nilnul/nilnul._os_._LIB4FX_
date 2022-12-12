using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started_.exit_.onDue
{
	/// <summary>
	/// </summary>
	public class _CodX
	{
		public static int _ExitCode(string cmd, string arg, string dir
			,
			int? life=null
			,
			int? bye=null
			,
			int? waitAftKill=null

		)
		{

			using (var proc = new prog.prep_.shell_.win_.min.proc_.started_.exit_.OnDue(cmd, arg, dir, life,bye,waitAftKill ))   
			{
				return proc.cod;
			}
		}

		
	}

	
}
