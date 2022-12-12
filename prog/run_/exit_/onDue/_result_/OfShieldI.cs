using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;

namespace nilnul.os.prog.run_.exit_.onDue._result_
{
	public interface OfShieldI
	{
		nilnul.os.proc_.finished._result.CodMsgErr result(string cmd, string arg, ShieldI dir, int? life = null, int? bye = null);


	}

	public abstract class OfShieldA :
		OfInfoA,
	OfShieldI
	,
	OfAddressI
	{
		

		public nilnul.os.proc_.finished._result.CodMsgErr result(string cmd, string arg, ShieldI dir, int? life = null, int? bye = null)
		{
			return ofAddress(cmd, arg,dir?.ToString(),life,bye);

		}

		//public override abstract prog._run.Result ofAddress(string cmd, string arg, string dir, int? life = null, int? bye = null);
	}

}
