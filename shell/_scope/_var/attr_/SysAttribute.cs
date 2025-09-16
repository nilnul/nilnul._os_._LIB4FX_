using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.shell._scope._var.attr_
{
	/// <summary>
	/// System Environment Variable
	/// (SETX /M)
	///		machine
	/// </summary>
	[System.AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	sealed class SysAttribute : Attribute
	{
		
	}
	
}
