using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.shell._scope.var.val_
{
	/// <summary>
	/// the val in a process is cached. eg: in visual studio test, multiple runs would still use the cached\unrefreshed value. to get refreshed val, do one of these:
	///		- use <see cref="EnvironmentVariableTarget.User"/>
	///		- restart vs
	/// </summary>
	internal class ProcessCached
	{
	}
}
