using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.shell._scope._var.attr_
{
	/// <summary>
	/// Volatile (Set at Logon
	/// </summary>
	[System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
	sealed class LogonAttribute : Attribute
	{
	}
	
}
