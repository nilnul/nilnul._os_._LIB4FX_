using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started_.exit
{
	/// <summary>
	/// </summary>
	public class _CodX
	{
		public static int _ExitCode(string cmd, string arg, string dir)
		{

			using (var proc = new prog.prep_.shell_.win_.min.proc_.started_.Waited(cmd, arg, dir))   
			{
				return proc.cod;
			}
		}

		
	}

	
}
