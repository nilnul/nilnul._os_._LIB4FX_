using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_
{
	static public  class _EvtEnabledX
	{
		static public void EnableEvt(Process _process_assumeUnstarted) {
			_process_assumeUnstarted.EnableRaisingEvents = true;
		}
	}
}
