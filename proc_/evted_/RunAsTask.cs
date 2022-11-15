using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.evted_
{
	internal class _RunAsTaskX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_evtEnabled"></param>
		/// <returns>
		/// the task wouldnot complete until the process exit;
		/// </returns>
		static Task<int> _RunAsTask(Process _evtEnabled)
		{
			var tcs = new TaskCompletionSource<int>();
	
			_evtEnabled.Exited += (sender, args) =>
			{
				tcs.SetResult(_evtEnabled.ExitCode);
				_evtEnabled.Dispose();
			};

			_evtEnabled.Start();

			return tcs.Task;
		}
	


	}
}
