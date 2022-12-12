using nilnul.os.prog.run;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit.cod.vow_
{
	public class FrCod<TCod> : VodA
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

		public override void ofAddress(string cmd, string arg, string dir)
		{
			try
			{
				 nilnul.num.integer_.int32.be_.nil.Vow.Singleton.vow(
					boxed.ofAddress(cmd, arg,dir)
				);

			}
			catch (Exception)
			{

				throw;
			}

		}

	

	}
}
