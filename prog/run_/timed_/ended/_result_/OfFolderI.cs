using nilnul.fs;
using nilnul.fs.address_;
using nilnul.win.prog._run._result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.timed_.ended._result_
{
	public interface OfFolderI
	{
		nilnul.os.proc_.finished._result.CodMsgErr result(string cmd, string arg=null, FolderI dir=null, int? life = null, int? bye = null);


	}

	public abstract class OfFolderA : 
	OfShieldA
	,
	OfFolderI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cmd"></param>
		/// <param name="arg"></param>
		/// <param name="dir"></param>
		/// <param name="life">how long the process is run before being timeout</param>
		/// <param name="bye"></param>
		/// <returns></returns>
		public nilnul.os.proc_.finished._result.CodMsgErr result(string cmd, string arg=null, FolderI dir=null, int? life = null, int? bye = null)
		{
			return result(cmd, arg, dir?.address.en,life,bye);

		}

	}

}
