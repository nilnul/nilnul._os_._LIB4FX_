using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.wait_.exit_.xpn_
{

	/// <summary>
	/// we waited for a period (which is deemed long), but the process is not exited; 
	/// </summary>
	[Serializable]
	public class Timeout : System.TimeoutException
	{
		public Timeout() { }
		public Timeout(string message) : base(message) { }
		public Timeout(string message, Exception inner) : base(message, inner) { }
		protected Timeout(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
