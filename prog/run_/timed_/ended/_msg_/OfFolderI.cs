using nilnul.fs;
using nilnul.fs.address_;
using nilnul.win.prog._run._result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.timed_.ended._msg_
{
	public interface OfFolderI
	{
		string msg(string cmd, string arg=null, FolderI dir=null, int? life = null, int? bye = null);


	}

	public abstract class OfFolderA :
	OfShieldA
		,
		OfFolderI
	{
		public string msg(string cmd, string arg=null, FolderI dir=null, int? life = null, int? bye = null)
		{
			return msg(cmd,arg,dir.address.en);
		}
		public string trimmed(string cmd, string arg = null, FolderI dir = null, int? life = null, int? bye = null)
		{
			return msg(cmd, arg= null, dir= null, life,bye)?.Trim();
		}
	}

}
