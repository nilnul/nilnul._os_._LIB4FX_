using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;

namespace nilnul.os.prog.run_.exit_.onDue._cod_
{
	public interface OfShieldI
	{
		int cod( string cmd, string arg=null, nilnul.fs.address_.ShieldI dir=null, int? life = null, int? bye = null);


	}

	public abstract class OfShieldA : OfAddressA, OfShieldI,OfAddressI
	{
		public int cod( string cmd, string arg=null, ShieldI dir=null, int? life = null, int? bye = null)
		{
			return ofAddress(cmd,arg, dir?.ToString(),life,bye);
		}

	
	}

}
