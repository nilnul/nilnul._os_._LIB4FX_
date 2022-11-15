using nilnul.txt.convert_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.txt.esc_.os_
{
	/*he Windows command-line interpreter uses a caret character (^) to escape reserved characters that have special meanings (in particular: &, |, (, ), <, >, ^).[4] The DOS command-line interpreter, though it supports similar syntax, does not support this.

For example, on the Windows Command Prompt, this will result in a syntax error.

echo <hello world>
whereas this will output the string: <hello world>

echo ^<hello world^>
*/
	/// <summary>
	/// escape the arg by: 1)quote space. 2) double middle quote
	/// </summary>
	public class Arg
		: nilnul.txt.EscI
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

			const string quote = "\"";
		public string escape(string boxed)
		{
			//string r;
			if (boxed.Contains(quote))
			{
				boxed=boxed.Replace(quote, $"{quote}{quote}");
			}

			if (
				boxed.Contains(quote)
				||
				nilnul.txt.be_.contain_.White.Singleton.be(boxed)
				||
				boxed == ""
			)
			{
				return $"{quote}{boxed}{quote}";
			}

			//no space
			return boxed;
		}

		const string DblQuote = quote + quote;

		public string unescape(string escaped)
		{

			//if (string.IsNullOrEmpty(escaped) )
			//{
			//	return escaped;
			//}
			if (escaped.StartsWith(quote ))
			{
				var deheaded = escaped.Substring(1);

				 string regex = $@"{quote}*\z";
				var matches=Regex.Match(deheaded, regex);

				var tail = matches.Value;
				var tailLength = tail.Length;

				var midStr = deheaded.Truncate( tailLength);


				midStr= midStr.Replace(DblQuote, quote);

				return $"{midStr}{ nilnul.txt.op_.unary_.RepeatX.Repeat(quote, tailLength/2 )}";




			}
			return escaped;
		}


		static public Arg Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Arg>.Instance;
			}
		}

	}
}
