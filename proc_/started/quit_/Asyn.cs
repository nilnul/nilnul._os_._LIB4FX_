using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.end_
{
	public class Asyn
	{

		public Task DownloadStringAsync(Uri url, Process _proc_evented1unstarted)
		{

			TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();

			//_proc_evented1unstarted.EnableRaisingEvents = true;

			_proc_evented1unstarted.Exited += (s, e) =>
			{

				tcs.SetResult(true);

			};

			_proc_evented1unstarted.Start();



			_proc_evented1unstarted.WaitForExit();
			return tcs.Task;
		}

	}
}
