using nilnul.os.prog.prep.proc_.started_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit.cod.vow_.frCod_
{
	public class Defaultable :
		Defaultable<Cod>

		//started.VodA
	{
		

		//	[ExpectedException(typeof(ArgumentException),
		//"A userId of null was inappropriately allowed.")]
		public void vod( os.prog.prep.proc_.started_.Waited exited)
		{
			using (var p = exited)
			{
				new nilnul.num.integer_.int32.be_.nil.Vow(
					p.ToString()
				).vow(
					p.cod
				);

			}
		}

		public void vod(nilnul.os.prog.PrepI prep)
		{
			vod(new Waited(prep));
		}

		//public override void ofAddress(string cmd, string arg = null, string dir = null)
		//{

		//	using (var p = new Exited_box(cmd, arg, dir))
		//	{
		//		new nilnul.num.integer_.int32.be_.nil.Vow(
		//			p.ToString()
		//		).vow(
		//			p.cod
		//		);

		//	}

		//}

		static public Defaultable Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Defaultable>.Instance;
			}
		}

	}
}
