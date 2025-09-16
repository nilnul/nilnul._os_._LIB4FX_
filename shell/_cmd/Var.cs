using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.shell._cmd
{

	internal class Var
	{
		/*
%~I         - expands %I removing any surrounding quotes (")
%~fI        - expands %I to a fully qualified path name
%~dI        - expands %I to a drive letter only
%~pI        - expands %I to a path only
%~nI        - expands %I to a file name only
%~xI        - expands %I to a file extension only
%~sI        - expanded path contains short names only
%~aI        - expands %I to file attributes of file
%~tI        - expands %I to date/time of file
%~zI        - expands %I to size of file
%~$PATH:I   - searches the directories listed in the PATH
               environment variable and expands %I to the
               fully qualified name of the first one found.
               If the environment variable name is not
               defined or the file is not found by the
               search, then this modifier expands to the
               empty string

The modifiers can be combined to get compound results:

%~dpI       - expands %I to a drive letter and path only
%~nxI       - expands %I to a file name and extension only
%~fsI       - expands %I to a full path name with short names only

:~start,length
		where start can be negative meaning from the end;the index of the strings is zero based
		eg:
			%var:~10,5%
Set Second=%Second:~-2%
		, get last two;
		 */

		/*note in .bat file, you have some special variables such as
		 %0

		 */
		/// <see cref="nilnul.fs.file_.ext_.ba"/>
	}
}
