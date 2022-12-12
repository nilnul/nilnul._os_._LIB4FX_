using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit
{
	public class Cod
		:CodA
		
	{

		
		public override  int ofAddress( string cmd, string arg=null, string dir=null)
		{
			return _CodX._ExitCode(
				cmd,arg,dir
			);
			
	

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
