using System;

namespace nilnul.os.shell._scope.var.val_
{
	/// <summary>
	/// the val in a process is cached. eg: in visual studio test, multiple runs would still use the cached\unrefreshed value. to get refreshed val, do one of these:
	///		- use <see cref="EnvironmentVariableTarget.User"/>
	///		- restart vs
	/// </summary>
	static public class _UsrX
	{
		static public string Get(string var) {
			return Environment.GetEnvironmentVariable(var, EnvironmentVariableTarget.User);
		}
	}
}
