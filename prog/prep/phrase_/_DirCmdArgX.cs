using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep.phrase_
{
	static public class _DirCmdArgX
	{
		static public string Phrase( string cmd, string arg, string dir)
		{
			return $@"{dir}:{cmd} {arg}";
		}
		static public string Phrase( ProcessStartInfo psi)
		{
			return Phrase(psi.FileName, psi.Arguments,psi.WorkingDirectory);
		}

	}
}
