using System;
using System.Collections.Generic;
using System.Text;

namespace nilnul.os.prog
{
	/// <summary>
	/// later, when the <see cref="os.IProg"/> is reified (replaced by a concrete program such as git), we can choose the way how that <see cref="os.IProg"/> is run;
	/// </summary>
	/// <remarks>
	/// a prog when run, can start up multiple processes. In some case, one of them is main process, and the others are derived.
	/// also the inputs have been reordered as:
	///		arg
	///		dir
	///		cmd
	/// </remarks>
	/// 
	public interface IRun
		:proc_.IStarted
		
	{
	}
}
