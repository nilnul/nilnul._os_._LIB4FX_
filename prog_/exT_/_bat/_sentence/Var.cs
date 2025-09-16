using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.exT_._bat._sentence
{

	internal class Var
	{

		// just getting the filename of your batch the easiest way would be to just use %~n0.
		//@echo %~n0
		/// <see cref="os.shell._cmd.Var"/> ,where %~nI means expansion to a file name;
		///

		/*
		 To get substrings of argument variables such as %0, %1, etc. you have to assign them to a normal environment variable using set first:

		:: Does not work:
		@echo %1:~10,5

		:: Assign argument to local variable first:
		set var=%1
		@echo %var:~10,5%


%var:~-7% extracts the last 7 characters from %var%
%var:~0,-4% would extract all characters except the last four which would also rid you of the file extension (assuming three characters after the period [.]).
See help set for details on that syntax.
		 */

		/*
%~0 expands to the name of the own batch, exactly as it was typed.
So if you start your batch it will be expanded as

%~0   - mYbAtCh
%~n0  - mybatch
%~nx0 - mybatch.bat		 
		 */

		/*
echo main- %~0
call :myFunction
exit /b

:myFunction
echo func - %~0
echo func - %~n0
exit /b
@rem for the above, exit /b means out of the batch,not the shell;
This results to

main - myBatch
Func - :myFunction
func - mybatch


In a function %~0 expands always to the name of the function, not of the batch file.
But if you use at least one modifier it will show the filename again!



nswered Jun 18, 2012 at 6:46
jeb

stackoverflow.com/questions/636381/what-is-the-best-way-to-do-a-substring-in-a-batch-file		 
		 */
	
	}
}
