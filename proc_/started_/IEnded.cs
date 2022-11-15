using System;
using System.Collections.Generic;
using System.Text;

namespace nilnul.os.proc_.started_
{
	/// <summary>
	/// the process has been started, and also ended/exited, hence we can retrieve exit code;
	/// note some process is being rebated back to os for killing, and the killing is async and might take time; WaitForExit for this might be infinite timely, if we leave early, its not exited; we can throw exception on this to treat this kind of proc as Ended;
	/// </summary>
	public interface IEnded:IStarted
	{
	}
}
