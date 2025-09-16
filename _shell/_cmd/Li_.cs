using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os._shell._cmd
{
	internal enum Li_
	{
		/// <summary>
		/// push current dir to stack, and change to the specified dir;
		/// </summary>
		PushD
			,
		/// <summary>
		/// pop out a dir from stack, and change to that dir.
		/// </summary>
		PopD
	}
}
