using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.os.proc_.finished._result;
using nilnul.win.prog._run;

namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_.min.proc_.errAsyn_.started_.timed_.stdSyn_.ended
{
	public class Result : nilnul.os.prog.run_.timed_.ended.ResultA
	{
	
		public  CodMsgErr ofAddress(string cmd, string arg, string dir, int? life = null, int? bye = null
			,int? waitAftKill=null
			)
		{
			using (var p = new Ended(cmd,arg,
				nilnul.fs.address.nulable.to_._OverlongX.PrependIfNeed(dir)
				//dir
				,life,bye,waitAftKill) )
			{
				return p.result();
			}

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cmd"></param>
		/// <param name="arg"></param>
		/// <param name="dir"></param>
		/// <param name="life"></param>
		/// <param name="bye">how long to wait to kill the program after an end request is sent out</param>
		/// <returns></returns>
		public override CodMsgErr ofAddress(string cmd, string arg, string dir, int? life = null, int? bye = null
			
			)
		{
			return ofAddress(
				cmd,
				arg,
				dir,
				life
				,
				bye
				,
				null
			);

		}

		static public Result Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Result>.Instance;
			}
		}

	}
}
