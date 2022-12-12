using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.abort_.xpn_
{

	/// <summary>
	/// not exited in time
	/// </summary>
	[Serializable]
	public class Timeout : System.TimeoutException
	{
		public Timeout() { }
		public Timeout(string message) : base(message) { }

		public Timeout(Process proc_unwaited):this( os.proc.prep.Phrase.Singleton.phrase(proc_unwaited))
		{
		}

		public Timeout(string message, Exception inner) : base(message, inner) { }
		protected Timeout(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
