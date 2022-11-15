using System;
using System.Collections.Generic;
using System.Text;

namespace nilnul.os._proc
{
	/// <summary>
	/// <see cref="ProcessStartInfo"/>
	/// note a prep might use nonprog, such as a file, or any comand that Os recognize; So we better use <see cref="IProc"/>, rather than <see cref="os.IProg"/>,  as the cannonical namsespace;
	///		also if we extend <see cref="_proc.IPrep"/>, it finally will reach <see cref="IProc"/>; and it's inappropriate to put <see cref="IProc"/> under <see cref="_proc"/>
	///		So we are left with only one choice: use <see cref="IProc"/>
	/// </summary>
	public interface IPrep
		
	{
	}
}
