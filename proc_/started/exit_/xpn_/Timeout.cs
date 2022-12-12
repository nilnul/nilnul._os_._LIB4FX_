using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.exit_.xpn_
{
	/// <summary>
	/// exited by being killed;
	/// note: the kill is successful; if the process is not exited after kill, <see cref="quit_.xpn_.Killing"/>
	/// </summary>

	[Serializable]
	public class Killed : System.Exception
	{
		public Killed() { }
		public Killed(string message) : base(message) { }
		public Killed(string message, Exception inner) : base(message, inner) { }
		protected Killed(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
