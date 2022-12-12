using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep.proc_.started_.waited
{
	/// <summary>
	/// </summary>
	public class _CodX
	{
		public static int _Cod_ofCmd9arg9dir(string cmd, string arg, string dir)
		{

			using (var proc = new prog.prep.proc_.started_.Waited(cmd, arg, dir))   
			{
				return proc.cod;
			}
		}

		
	}

	
}
