using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit.cod.retCrash_.frCod_
{
	public class Defaultable : Defaultable<Cod>
	{

		static public Defaultable Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Defaultable>.Instance;
			}
		}


	}
}
