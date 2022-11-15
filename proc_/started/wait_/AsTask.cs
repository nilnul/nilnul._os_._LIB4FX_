using nilnul.obj.box_.ref_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.wait_
{
	static public class _AsTaskX
	{
		/// <summary>
		/// returna early if ended; or return false when timeout;
		/// </summary>
		/// <param name="process"></param>
		/// <param name="timeout"></param>
		/// <returns></returns>
		public static Task<bool> WaitAsTask(this Process process, int timeout)
		{
			return Task.Run(
				() => process.WaitForExit(timeout)
			);
		}
	}
}
