using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_
{
	internal class _RunAsTaskX
	{
		
		static Task _RunAsTask(Process _started)
		{
			return Task.Run(() => _started.WaitForExit());
		}


	}
}
