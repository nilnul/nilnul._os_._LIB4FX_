using nilnul.fs;
using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit_.onDue._msg_
{
	public interface OfFolderI
	{
		string msg(string cmd, string arg=null, FolderI dir=null, int? life = null, int? bye = null);


	}

}
