using nilnul.fs.address_.spear_.based_;
using nilnul.fs.address_.spear_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.shell.cmd.run_
{
	static public class _ByExeX
	{
		static public Process _Process_0cmd_1args_2dir(

			string cmd
			,
			IEnumerable<string> args
			,
			string workingDir
		)
		{

			var args4cmd = new nilnul.os.prog._prep._argument.Args(
				new string[] {
					"/C"
					,
					cmd }.Concat(args)
			);

			//@"C:\Windows\System32\cmd.exe";
			var p = Process.Start(
				new ProcessStartInfo("cmd.exe", args4cmd.ToString())
				{
					//Verb = "runas",
					UseShellExecute = true
					,
					WorkingDirectory = workingDir
				}
			);

			return p;

		}


	}
}
