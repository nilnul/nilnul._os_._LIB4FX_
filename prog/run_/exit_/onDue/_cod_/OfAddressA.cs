
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit_.onDue._cod_
{
	/// <summary>
	/// don't care about result
	/// </summary>
	public abstract class OfAddressA
		:
		OfPrepA
		,
		OfAddressI
	{
		public int ofAddress(string cmd, string arg = null, string dir = null, int? life = null, int? bye = null)
		{
			return cod(
				new Prep(cmd,arg,dir),life,bye
			);

		}
	}



}
