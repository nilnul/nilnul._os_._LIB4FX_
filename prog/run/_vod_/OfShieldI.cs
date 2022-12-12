using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;

namespace nilnul.os.prog.run._vod_
{
	public interface OfShieldI
	{
		void vod(string cmd, string arg=null, ShieldI dir=null);


	}

	public abstract class OfShieldA :  OfShieldI,OfAddressI
	{
		public void vod(string cmd, string arg=null, ShieldI dir=null)
		{
			 ofAddress(cmd,arg,dir?.ToString());
		}

		public abstract void ofAddress(string cmd, string arg=null, string dir=null);
	}

}
