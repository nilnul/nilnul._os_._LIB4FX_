using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.current
{
	static public  class _ExtensionsX
	{

		[DllImport("kernel32.dll")]
		static extern IntPtr GetConsoleWindow();
	}
}
