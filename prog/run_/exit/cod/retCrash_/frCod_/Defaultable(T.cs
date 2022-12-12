using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit.cod.retCrash_.frCod_
{
	public class Defaultable<TCod> : FrCod<TCod>
		where TCod: CodI,new()
	{
		public Defaultable() : base(nilnul.obj_.singleton_.Lazy<TCod>.Instance)
		{
		}

		static public Defaultable<TCod> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Defaultable<TCod>>.Instance;
			}
		}

	}
}
