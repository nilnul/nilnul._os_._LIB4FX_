using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.shell_
{
	/// <summary>
	/// 
	/// </summary>
	/// "/K ipconfig" would keep the window open;
	/// "/C" would close the window;
	///		eg:
	///			Process.Start("cmd", "/c command & pause");
	/// without /K or /C, the directive is not executed.
	internal class _CmdX
	{
	}
}
