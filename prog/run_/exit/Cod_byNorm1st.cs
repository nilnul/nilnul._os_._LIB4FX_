using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.run_.exit
{
	public class Cod_byNorm1st
		:CodA
		
	{

		
		public override  int ofAddress( string cmd, string arg=null, string dir=null)
		{
			return _CodX_byNorm1st._ExitCode(
				cmd,arg,dir
			);
			
	

		}


		static public Cod_byNorm1st Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cod_byNorm1st>.Instance;
			}
		}

	}

	
}
