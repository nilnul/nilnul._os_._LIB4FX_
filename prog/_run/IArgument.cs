using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog._run
{
	///https://learn.microsoft.com/en-US/troubleshoot/windows-client/shell-experience/command-line-string-limitation
	///
	/// The limit for the length of a command line is not imposed by the shell, but by the operating system. This limit is usually in the range of hundred kilobytes.
	/// 
	/// <summary>
	/// Although a bad idea, Process.start with useshellexecute=false would invoke createprocess() which allows for 32767 characters in the command line (although this is also the maximum size for the entire environment block);
	/// </summary>
	/// <remarks>
	/// On computers running Microsoft Windows XP or later, the maximum length of the string that you can use at the command prompt is 8191 characters. On computers running Microsoft Windows 2000 or Windows NT 4.0, the maximum length of the string that you can use at the command prompt is 2047 characters.
	/// </remarks>
	/// 
	internal interface IArgument
	{
	}
}
