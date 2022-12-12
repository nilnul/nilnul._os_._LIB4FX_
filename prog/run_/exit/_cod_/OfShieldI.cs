using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;

namespace nilnul.os.prog.run_.exit._cod_
{
	public interface OfShieldI
	{
		int cod( string cmd, string arg=null, nilnul.fs.address_.ShieldI dir=null);


	}

	public abstract class OfShieldA :  OfShieldI,OfAddressI
	{
		public int cod( string cmd, string arg=null, ShieldI dir=null)
		{
			return ofAddress(cmd,arg, dir.ToString());
		}

		public abstract int ofAddress(string cmd, string arg=null, string dir=null);
	}

}
