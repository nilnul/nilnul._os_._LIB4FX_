
using System;
using System.Threading;

namespace nilnul.os.prog.run_.exit_.onDue._cod_
{
	public abstract class OfPrepA :
		OfPrepI
	{
		public abstract int cod(PrepI timeout, int? life = null, int? bye = null);
		public int cod(PrepA timeout, int? life = null, int? bye = null)
		{
			return cod((PrepI)timeout, life, bye);

		}

		public int cod(Prep timeout, int? life = null, int? bye = null)
		{
			return cod((PrepI)timeout, life, bye);

		}


	}
}