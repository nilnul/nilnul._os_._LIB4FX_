using System;
using System.Collections.Generic;
using System.Text;

namespace nilnul.os.proc_.started
{
	///
	///  if it's killed, an exception is thrown; killing is considered done, as it's up to the os to clean up.
	/// 
	/// <summary>
	/// kill, and wait
	/// 
	/// end the proc, one way or another;
	/// If it's endable, throw exception or leave it there untended;
	/// </summary>
	/// <remarks>
	/// in other words, we ignore the returned exited being true or false;
	/// </remarks>
	/// 
	/// alias:
	///		quit
	///			"q"lose, k"ui"ll, wai"t"
	///		end
	///			corresponding to <see cref="IStarted"/>
	///		die
	///		exit
	///		retreat
	///		rot
	///		decay
	///		leave
	///		desert
	public interface IQuit
	{
	}

}
