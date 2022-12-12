using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started_.invis_.botPopTitDelay_.waited
{
	/// <summary>
	/// dispose the process of Proc
	/// </summary>
	public class Vod:nilnul.win.proc_.started.VodA
	{

		static public Vod Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vod>.Instance;
			}
		}

		public override void ofAddress(string cmd, string arg = null, string dir = null)
		{
			using (var p = new Waited(cmd, arg, dir))
			{

			}

		}
	}
}
