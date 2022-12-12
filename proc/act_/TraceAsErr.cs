using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc.act_
{
	/// <summary>
	/// </summary>
	static public class _TraceAsErrX
	{

		static public void TraceAsErr(
			ref Process proc
						,
		[System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
		[System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
		[System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0

		)

		{
			Trace.TraceError(
				$@"
{nilnul.os.prog.prep.Phrase.Singleton.phrase(proc.StartInfo)}

{_proc._trace._CallSiteX.TxtOfCallSite(memberName, sourceFilePath, sourceLineNumber)}"
			);
		}


		static public void OfMsg(
			ref Process proc
			,
			string msg
						,
		[System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
		[System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
		[System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0

		)

		{
			Trace.TraceError(
				$@"
{nilnul.os.prog.prep.Phrase.Singleton.phrase(proc.StartInfo)}
:::
{msg}
:::
{_proc._trace._CallSiteX.TxtOfCallSite(memberName, sourceFilePath, sourceLineNumber)}"
			);
		}


		static public void TraceAsErr(
			ref Process proc
			,
			Exception msg
						,
		[System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
		[System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
		[System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0

		)

		{
			Trace.TraceError(
				$@"
{nilnul.os.prog.prep.Phrase.Singleton.phrase(proc.StartInfo)}
:::
{msg}
:::
{_proc._trace._CallSiteX.TxtOfCallSite(memberName, sourceFilePath, sourceLineNumber)}"
			);
		}

		public static void TraceAsErr(Process proc, Exception e,                        
		[System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
		[System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
		[System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0
)
		{
			OfMsg(ref proc, e.ToString(), memberName,sourceFilePath,sourceLineNumber);
		}
	}
}

