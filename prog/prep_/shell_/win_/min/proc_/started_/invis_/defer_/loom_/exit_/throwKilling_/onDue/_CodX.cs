using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started_.invis_.defer_.loom_.exit_.throwKilling_.onDue
{
	/// <summary>
	/// </summary>
	public class _CodX
	{
		public static int _ExitCode(string cmd, string arg, string dir
			,int? lurk=null
			,
			int? life=null
			,
			int? bye=null
			,
			int? waitAftKill=null

		)
		{

			using (var proc = new prog.prep_.shell_.win_.min.proc_.started_.invis_.defer_.loom_.exit_.throwKilling_.OnDue(cmd, arg, dir, lurk,life,bye,waitAftKill ))   
			{
				return proc.cod;
			}
		}

		
	}

	
}
