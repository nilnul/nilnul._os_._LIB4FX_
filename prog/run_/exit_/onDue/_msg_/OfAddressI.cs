using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit_.onDue._msg_
{
	public interface OfAddressI
	{
		string ofAddress(string cmd, string arg=null, string dir=null, int? life = null, int? bye = null);

	}

	public abstract class OfAddressA: OfAddressI
	{
		public abstract string ofAddress(string cmd, string arg, string dir, int? life = null, int? bye = null);
		

	}




}
