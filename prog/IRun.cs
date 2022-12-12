using System;
using System.Collections.Generic;
using System.Text;

namespace nilnul.os.prog
{
	/// <summary>
	/// later, when the <see cref="os.IProg"/> is reified, we can choose the way how that <see cref="os.IProg"/> is run;
	/// </summary>
	/// <remarks>
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
