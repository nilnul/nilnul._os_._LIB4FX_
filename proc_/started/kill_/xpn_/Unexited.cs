using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.kill_.xpn_
{

	/// <summary>
	///kill request issued, on return, the process is not exited;
	///killing generally need some time, but we have that patience
	/// </summary>
	[Serializable]
	public class Unexited : System.Exception
	{
		public Unexited() { }
		public Unexited(string message) : base(message) { }

		public Unexited(Process proc_started):this( os.proc.prep.Phrase.Singleton.phrase(proc_started))
		{
		}

		public Unexited(string message, Exception inner) : base(message, inner) { }
		protected Unexited(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
