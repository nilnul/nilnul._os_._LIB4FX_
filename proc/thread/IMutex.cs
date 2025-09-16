using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc.thread
{
	/// <summary>
	/// We can prefix Mutex names with either
	///		Global\ or Local\.
	/// The exact behavior of these prefixes varies by platform, but Mutex instances with the former prefix are generally visible throughout the entire system;
	/// those prefixed with the latter may be more isolated.
	/// </summary>
	internal class IMutex
	{
	}
}
