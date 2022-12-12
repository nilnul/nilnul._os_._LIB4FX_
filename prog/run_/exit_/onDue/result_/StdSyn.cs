using System;
using System.Diagnostics;

namespace nilnul.os.prog.run_.exit_.onDue.result_
{
	/// <summary>
	/// to get the result in time, nonShell/redirStd/redirErr/errAsn/(stdSyn) is required.
	/// </summary>
	///
	public  class StdSyn: nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_.min.proc_.errAsyn_.started_.timed_.stdSyn_.exit.Result
	{

		static public StdSyn Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<StdSyn>.Instance;
			}
		}

	}
}
