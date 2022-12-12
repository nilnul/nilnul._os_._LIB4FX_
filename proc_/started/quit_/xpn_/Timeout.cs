using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.quit_.xpn_
{

	/// <summary>
	/// killed, but unexited in time
	/// </summary>
	[Serializable]
	public class Timeout : started. wait_.exit_.xpn_.Timeout
	{
		public Timeout() { }
		public Timeout(string message) : base(message) { }
		public Timeout(string message, Exception inner) : base(message, inner) { }
		protected Timeout(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
