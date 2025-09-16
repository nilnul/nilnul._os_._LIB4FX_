using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog._prep
{
	/// <summary>
	/// a str of args;
	/// </summary>
	/// vs:
	///		<see cref="_argument.IArg"/>: if you put a txt directly as arg, the space in it might render itself as two or more args. So you better wrap it in argument, which will wrap the whole txt by escaping the space, and would render the whole as a single arg.
	internal class IArgument
	{
	}
}
