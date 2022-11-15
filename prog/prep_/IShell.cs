using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_
{
	/// <summary>
	/// run the prog using shell;
	/// The default is true on .NET Framework apps ( and false on .NET Core apps ).
	/// </summary>
	/// UseShellExecute must be true if you set the ErrorDialog property to true.
	/// The word "shell" in this context (UseShellExecute) refers to a graphical shell (similar to the Windows shell) rather than command shells (for example, bash or sh) and lets users launch graphical applications or open documents.
	public interface IShell
		:os.prog.IPrep
	{
	}
}
