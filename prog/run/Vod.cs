using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run
{
	public class Vod : VodA
	{
		public override void ofAddress(string cmd, string arg = null, string dir = null)
		{
			using (var p = new os.prog.prep.proc_.Started(cmd,arg,dir))
			{

			}
		}


		static public Vod Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vod>.Instance;
			}
		}

	}


}
