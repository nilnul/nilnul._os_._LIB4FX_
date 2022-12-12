using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit
{
	/// <summary>
	/// </summary>
	public class _CodX
	{
		/// <summary>
		/// cmd,arg,dir
		/// </summary>
		/// <param name="cmd"></param>
		/// <param name="arg"></param>
		/// <param name="dir"></param>
		/// <param name="lurk"></param>
		/// <returns></returns>
		public static int _ExitCode(string cmd, string arg, string dir, int? lurk = null
		//	, int? life = null, int? bye = null, int? waitAftKill = null
		)
		{

			return
				os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.waited._CodX.OfAddress //it's the process's responsibility to end gracefully
				//os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.quit_.onDue._CodX._ExitCode
				(cmd, arg, dir,lurk
				//,life,bye,waitAftKill
			);
		}


		
	}

	
}
