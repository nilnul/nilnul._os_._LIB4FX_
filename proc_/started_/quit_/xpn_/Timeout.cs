using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.waited_.xpn_
{

	[Obsolete(nameof(started.wait_.exit_.xpn_.Timeout))]

	[Serializable]

	public class TimeoutException : System.TimeoutException
	{
		public TimeoutException() { }
		public TimeoutException(string message) : base(message) { }
		public TimeoutException(string message, Exception inner) : base(message, inner) { }
		protected TimeoutException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
