using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;

namespace nilnul.os.prog.run_.timed_.ended._msg_
{
	public interface OfShieldI
	{
		string msg(string cmd, string arg=null, ShieldI dir=null, int? life = null, int? bye = null);


	}

	public abstract class OfShieldA :  OfShieldI,OfAddressI
	{
		public abstract string ofAddress(string cmd, string arg=null, string dir=null, int? life = null, int? bye = null);
		public string msg(string cmd, string arg=null, ShieldI dir=null, int? life = null, int? bye = null)
		{
			return ofAddress(cmd,arg,dir?.ToString(),life,bye);
		}
		

	}

}
