using nilnul.fs;
using nilnul.fs.address_;
using nilnul.win.prog._run._result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.ended._result_
{
	public interface OfFolderI
	{
		nilnul.os.proc_.finished._result.CodMsgErr result(string cmd, string arg, FolderI dir );


	}

	public abstract class OfFolderA : 
	OfShieldA
	,
	OfFolderI
	{

		public nilnul.os.proc_.finished._result.CodMsgErr result(string cmd, string arg, FolderI dir )
		{
			return result(cmd, arg, dir.address.en);

		}

	}

}
