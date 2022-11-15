using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.win.prog._run._result;

namespace nilnul.os.prog.run_.timed_.ended._result_
{
	public interface OfInfoI
	{
		nilnul.os.proc_.finished._result.CodMsgErr result(string cmd, string arg, DirectoryInfo dir, int? life = null, int? bye = null);


	}

	public abstract class OfInfoA :
	OfInfoI
	,
	OfAddressI
	{
		

		public nilnul.os.proc_.finished._result.CodMsgErr result(string cmd, string arg, DirectoryInfo dir, int? life = null, int? bye = null)
		{
			return ofAddress(cmd, arg,dir?.ToString(),life,bye);

		}

		public abstract nilnul.os.proc_.finished._result.CodMsgErr ofAddress(string cmd, string arg, string dir, int? life = null, int? bye = null);
	}

}
