using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog._prep._argument
{

	
	/// <summary>
	/// escape the arg by: 1)quote space. 2) double middle quote
	/// </summary>
	public class Arg
	{

		/*Note: The Rules Changed in 2008 
Arguments are delimited by white space, which is either a space or a tab.
The caret character (^) is not recognized as an escape character or delimiter. The character is handled completely by the command-line parser in the operating system before being passed to the argv array in the program. 
They are referring to the scenario discussed in sec. 6.2 below, where first the command line parser (cmd.exe) parses your command, handling such things as the escape character ^ , the redirection characters > & < , the pipe character | , the %  character which may identify environment variables that need to be expanded (e.g. %PROGRAMFILES%), etc. The rules here describe how your C/C++ executable will parse the lpCommandLine that was passed to CreateProcess() by cmd.exe or whoever calls CreateProcess(). 
A string surrounded by double quotation marks ("string") is interpreted as a single argument, regardless of white space contained within. A quoted string can be embedded in an argument. 
The double quotes don't have to be around the whole parameter. A double quoted part may occur anywhere in the parameter. 
A double quotation mark preceded by a backslash (\") is interpreted as a literal double quotation mark character (").
Backslashes are interpreted literally, unless they immediately precede a double quotation mark.
If an even number of backslashes is followed by a double quotation mark, one backslash is placed in the argv array for every pair of backslashes, and the double quotation mark is interpreted as a string delimiter.
If an odd number of backslashes is followed by a double quotation mark, one backslash is placed in the argv array for every pair of backslashes, and the double quotation mark is "escaped" by the remaining backslash, causing a literal double quotation mark (") to be placed in argv.
The missing undocumented rule has to do with how doubledouble quotes ("") are handled: 
Prior to 2008: 
If a closing " is followed immediately by another ", the 2nd " is accepted literally and added to the parameter. 
After 2008 
A double quote encountered outside a double quoted block starts a double quoted block.
A double quote encountered inside a double quoted block: 
not followed by another double quote ends the double quoted block.
followed immediately by another double quote (e.g. ""), a single double quote is added to the output, and the double quoted block continues.*/

		private string _raw;
		public Arg(string val)
		{
			_raw = val;
		}

		public override string ToString()
		{

			return nilnul.txt.esc_.os_.Arg.Singleton.escape(_raw);
		}

		
		
	}
}
