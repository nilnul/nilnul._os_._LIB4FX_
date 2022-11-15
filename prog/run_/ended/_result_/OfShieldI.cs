using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.win.prog._run._result;

namespace nilnul.os.prog.run_.ended._result_
{
	public interface OfShieldI
	{
		nilnul.os.proc_.finished._result.CodMsgErr result(string cmd, string arg, ShieldI dir);


	}

	public abstract class OfShieldA :
		OfShieldI
		,
		OfAddressI
	{


		public nilnul.os.proc_.finished._result.CodMsgErr result(string cmd, string arg, ShieldI dir)
		{
			return ofAddress(cmd, arg, dir.ToString());

		}

		public abstract nilnul.os.proc_.finished._result.CodMsgErr ofAddress(string cmd, string arg, string dir);
	}

}
