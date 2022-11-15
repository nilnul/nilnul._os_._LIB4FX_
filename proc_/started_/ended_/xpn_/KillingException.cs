using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.ended_.xpn_
{

	[Serializable]
	public class KillingException : System.Exception
	{
		public KillingException() { }
		public KillingException(string message) : base(message) { }
		public KillingException(string message, Exception inner) : base(message, inner) { }
		protected KillingException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
