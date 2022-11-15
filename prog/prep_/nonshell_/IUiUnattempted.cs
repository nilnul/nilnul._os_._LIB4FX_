using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;
using nilnul.win.prog._run;
using nilnul.win.prog._run.prep_.nonShell_.redirStd_;

namespace nilnul.os.prog.prep_.nonshell_
{

	/// <summary>
	/// true if the process should be started without creating a new window to contain it; otherwise, false.
	/// The default is false.
	/// This is not the default behavior
	/// </summary>
	/// If the UseShellExecute property is true or the UserName and Password properties are not null, the CreateNoWindow property value is ignored and a new window is created.
	/// .NET Core does not support creating windows directly on Unix-like platforms, including macOS and Linux.This property is ignored on such platforms.
	public interface IUiUnattempted
		:prep_.IUiUnattempted
	{



	}
}
