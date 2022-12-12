using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.kill_.xpn_
{
	/// <summary>
	/// the proc is not gracefully exit, but killed forcefully;
	/// a crashLanding
	/// </summary>
	/// <see cref="started.kill_.exit_.xpn_.Fail"/>

	[Serializable]
	public class ThouShaltNotKill : Exception
	{
		public ThouShaltNotKill() { }
		public ThouShaltNotKill(string message) : base(message) { }

		public ThouShaltNotKill(Process proc_started):this(os.proc.prep.Phrase.Singleton.phrase(proc_started))
		{
		}

		public ThouShaltNotKill(string message, Exception inner) : base(message, inner) { }
		protected ThouShaltNotKill(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
