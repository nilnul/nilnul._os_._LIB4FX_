using nilnul.fs;
using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit_.onDue._cod_
{
	public interface OfFolderI
	{
		int cod( string cmd, string arg=null, nilnul.fs.FolderI dir=null, int? life = null, int? bye = null);


	}

	public abstract class OfFolderA :
	OfShieldA
		,
		OfFolderI
	{
		public int cod(string cmd, string arg=null,  FolderI dir=null, int? life = null, int? bye = null)
		{
			return cod(cmd,arg, dir?.address.en,life,bye);
		}
	}

}
