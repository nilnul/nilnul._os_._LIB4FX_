using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace nilnul.os.prog.run_.exit_.onDue
{
	public class Cod
		: CodA

	{


		public override int cod(PrepI prep, int? life = null, int? bye = null)
		{
			return _CodX.Cod(prep,null,life,bye,null);
			//return   new prog.prep_.shell_.win_.min.proc_.started_.invis_.defer_.loom_.quit_.OnDue(prep , life, bye).cod  ;
		}

		public  int cod(nilnul.os.prog.Prep prep, int? life = null, int? bye = null)
		{

			return cod( new Prep(prep) ,life, bye);
			//using (var proc = new proc_.started_.doodle_.Quit(prep , life, bye))    //process is a in-thread object for storeing the info of a system.process
			//{
			//	return proc.cod;
			//}
		}

		public  int cod(ProcessStartInfo prep, int? life = null, int? bye = null)
		{
			return cod( new Prep(prep) ,life, bye);

			//using (var proc = new proc_.started_.doodle_.Quit(prep , life, bye))    //process is a in-thread object for storeing the info of a system.process
			//{
			//	return proc.cod;
			//}
		}



		static public Cod Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cod>.Instance;
			}
		}

	}


}
