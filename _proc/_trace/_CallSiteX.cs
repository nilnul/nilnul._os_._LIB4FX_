using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os._proc._trace
{
	/// <summary>
	/// </summary>
	static public class _CallSiteX
	{

		static public string TxtOfCallSite(
		[System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
		[System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
		[System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0

		)

		{
			return System.Text.Json.JsonSerializer.Serialize(
				new {
					memberName = memberName, sourceFilePath = sourceFilePath, sourceLineNumber = sourceLineNumber
				}
			);
		}

	

	}
}
