using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.address_.spear_;

namespace nilnul.os.prog_.exT_.bat
{
	static public class _RunX
	{
		public static void Run(string bat, string dir)
		{
			//var bat = @"E:\_temp\a\a.bat";

			var info = new ProcessStartInfo();
			info.FileName = bat;
			info.WorkingDirectory = dir; // default is _TEST_/bin/Debug
			info.UseShellExecute = true;// !info.UseShellExecute;
			var proc = new Process();
			proc.StartInfo = info;
			proc.Start();
		}
		public static void Run(nilnul.fs.address_.SpearI parentDoc1, ShieldI parent)
		{
			Run(parentDoc1.ToString(), parent.ToString());
		}
		public static void RunInParent(ParentDoc parentDoc1)
		{
			Run(parentDoc1, parentDoc1.parent);
		}
		public static void RunInParent(string bat)
		{
			RunInParent( nilnul.fs.address_.spear_.ParentDoc.Parse(bat));
		}


	}
}
