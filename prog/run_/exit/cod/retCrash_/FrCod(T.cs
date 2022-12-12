using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit.cod.retCrash_
{
	public class FrCod<TCod> : CodA
		where TCod: CodI
	{
		private TCod _boxed;

		public TCod boxed
		{
			get { return _boxed; }
			set { _boxed = value; }
		}
		public FrCod(TCod codMsg)
		{
			_boxed = codMsg;
		}

		public override int ofAddress(string cmd, string arg, string dir)
		{
			
				try
				{
					return _boxed.ofAddress(cmd, arg, dir);
				}
				catch (System.Exception e)
				{
					return int.MinValue;
				}


		}

	

	}
}
