using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog._run_
{
	public interface OfCmdArgDirI
	{

		/// <summary>
		/// not the order the pars are: cad, namely, cmd, arg, dir;
		/// the order is the same for <see cref="prog.PrepA"/>
		///			is different in <see cref="_proc.prep.phrase_._DirCmdArgX"/>
		///			same as <see cref="os.proc_.Started"/>
		/// </summary>
		/// <param name="cmd"></param>
		/// <param name="arg"></param>
		/// <param name="dir"></param>
		void _vod_ofCmd9arg9dir(string cmd, string arg, string dir);
	}

	


}
