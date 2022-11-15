using System;
using System.Diagnostics;

namespace nilnul.os.prog.run_.timed_.ended.result_
{
	/// <summary>
	/// to get the result in time, nonShell/redirStd/redirErr/errAsn/(stdSyn) is required.
	/// </summary>
	///
	[Obsolete(nameof(result_.StdSyn) + " is preferred as this brings about a weird issue: the line breaks are gone even if we add line breaks manually;",true)]

	public class StdAsyn: nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_.stdAsyn_.started_.timed_.ended.Result
	{

		static public StdAsyn Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<StdAsyn>.Instance;
			}
		}

	}
}
