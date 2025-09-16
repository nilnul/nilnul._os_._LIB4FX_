using System;
using System.Collections.Generic;
using System.Text;

namespace nilnul.os.proc_
{
	/// <summary>
	/// the process has been started; it may or may not ended;
	/// </summary>
	/// <remarks>
	///When a process starts, it is assigned memory and resources.
	/// </remarks>
	/// <see cref="proc.IStart"/>
	public interface IStarted
		:IProc
	{
	}
}
