using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.quit_.xpn_
{
	/// <summary>
	/// killing;
	/// the process might be exited, or we leave it there, when for example it's not responding;
	/// </summary>

	[Serializable]
	public class Killing : System.Exception
	{
		public Killing() { }
		public Killing(string message) : base(message) { }

		public Killing(Process proc_started):this( os.proc.prep.Phrase.Singleton.phrase(proc_started))
		{
		}

		public Killing(string message, Exception inner) : base(message, inner) { }
		protected Killing(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
