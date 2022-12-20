using System;
using System.Collections.Generic;
using System.Text;

namespace nilnul.os.proc_.started
{
	/// <summary>
	/// exited or exception(leave it to the os );
	/// </summary>
	/// alias:
	///		cease
	///		cede
	///		waive
	///		abjure
	///		relinquish
	///		leave
	///		recess
	///		disavow
	///		end
	///			corresponding to <see cref="IStarted"/>
	///		die
	///		exit
	///		retreat
	public interface IQuit4Close9kill9wait
	{
	}

}
///
///  if it's killed, an exception is thrown; killing is considered done, as it's up to the os to clean up.
/// end the proc, one way or another;
/// If it's endable, throw exception or leave it there untended;
/// in other words, we ignore the returned exited being true or false;
/// 
