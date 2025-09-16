using nilnul.fs.address_.spear_.based_;
using nilnul.fs.address_.spear_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using nilnul.os.prog._prep._argument;

namespace nilnul.os.shell.cmd.run_
{
	static public class _ByVbX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cli">include the cmd, args; the full input for command line;</param>
		/// <returns></returns>
		static public int _ProcId_assumeCli(

			string cli
			,
			AppWinStyle style =AppWinStyle.Hide
		)
		{

			return Interaction.Shell(
				//"copy /b Image1.jpg + Archive.rar Image2.jpg"
				cli
				,
				style
				
			);
		

		}

		static public int _ProcId_0cmd(

			string cmd
			,
			Args args
			,
			AppWinStyle style =AppWinStyle.Hide
		)
		{

			return Interaction.Shell(
				//"copy /b Image1.jpg + Archive.rar Image2.jpg"
				$"{cmd} {args}"
				,
				style
				
			);
		

		}
		static public int _ProcId_0cmd(

			string cmd
			,
			IEnumerable<string> args
			,
			AppWinStyle style =AppWinStyle.Hide
		)
		{

			return _ProcId_0cmd(cmd, new Args(args),style);
		

		}




	}
}
