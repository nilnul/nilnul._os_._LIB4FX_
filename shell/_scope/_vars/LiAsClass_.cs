using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.shell._scope._vars
{
	/// this is a list of names, each of which is annotated;
	/// for a list, the best storage format wouldnot be Csv, as it's a 2d table, not a 1d list;
	/// we might consider using a txt of lines, each of which is a key annotated with a description;
	/// As the key is nom(without punc), the enum would be the simplest form, simpler than txt of line;
	/// <summary>
	/// 
	/// </summary>
	internal class Li_
	{
		/// <summary>
		/// without enclosing "%%";
		/// %SystemDrive%
		/// </summary>
		public const string SystemDrive = "SystemDrive";

		/// <summary>
		/// 
		/// </summary>
		public const string SystemRoot = "SystemRoot";
		/// <summary>
		/// A random integer number, anything from 0 to 32,767 (inclusive).
		/// </summary>
		public const string RANDOM = "RANDOM";

		public string Wrap(string x) {
			return $"%{x}%";
		}

	}
}
