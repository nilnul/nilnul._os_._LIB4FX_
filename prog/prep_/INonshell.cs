using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_
{
	/// <summary>
	///  For executable, this is  recommended, <see cref="prep_.shell_.IUxp"/>, as this is prog and it can run in nonshell; Setting useShell to false enables you to redirect input, output, and error streams.
	/// The default for userShell is false on .NET Core apps.
	/// This is not the default;
	/// </summary>
	/// UseShellExecute must be false if the UserName property is not null or an empty string, or an InvalidOperationException will be thrown when the Process.Start(ProcessStartInfo) method is called.
	public interface INonshell
		:os.prog.IPrep
	{
	}
}
