using nilnul.fs.address_.spear_.based_;
using nilnul.fs.address_.spear_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace nilnul.os.shell.cmd.run_
{
	static public class _ByDllImportX
	{

		[DllImport("msvcrt.dll")]
		public static extern int system(string format);

		//system("copy Test.txt Test2.txt");
		static public int _Cod_0cmd_1args(

			string cmd
			,
			IEnumerable<string> args
		)
		{
			return system(
				$"{cmd} {args.ToString()}"
			);

		}


	}
}
