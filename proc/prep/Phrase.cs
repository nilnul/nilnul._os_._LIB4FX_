using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc.prep
{
	public class Phrase :
		nilnul.obj.PhraseI<Process>
	{
	

		public string phrase(Process obj)
		{
			return os.prog.prep.Phrase.Singleton. phrase(obj.StartInfo);
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
