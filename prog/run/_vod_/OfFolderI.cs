using nilnul.fs;
using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run._vod_
{
	public interface OfFolderI
	{
		void vod(string cmd, string arg=null, FolderI dir=null );


	}

	public abstract class OfFolderA :
	OfShieldA
		,
		OfFolderI
	{
		public void vod(string cmd, string arg=null, FolderI dir=null )
		{
			 vod(cmd,arg,dir?.address.en);
		}
	}

}
