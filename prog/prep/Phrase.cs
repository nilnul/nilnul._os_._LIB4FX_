using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep
{
	public class Phrase : nilnul.obj.PhraseI<ProcessStartInfo>
	
	{
		public string phrase(ProcessStartInfo obj)
		{
			return phrase(obj.FileName,obj.Arguments,obj.WorkingDirectory);

		}


		public string phrase( string cmd, string arg=null, string dir=null)
		{
			return $@"{dir}: {cmd} {arg}";

		}

	

		static public Phrase Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Phrase>.Instance;
			}
		}

	}
}
