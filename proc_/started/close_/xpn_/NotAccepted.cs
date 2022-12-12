using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.close_.xpn_
{
	/// <summary>
	/// the request4close is not accepted
	/// if the associated process does not have a main window or if the main window is disabled (for example if a modal dialog is being shown).
	/// </summary>


	[Serializable]
	public class NotAccepted : Exception
	{
		public NotAccepted() { }
		public NotAccepted(string message) : base(message) { }
		public NotAccepted(string message, Exception inner) : base(message, inner) { }
		protected NotAccepted(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
