using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started_.doodle_.loom_.exit_.onDue
{
	/// <summary>
	/// </summary>
	public class _CodX
	{
		public static int _ExitCode(string cmd, string arg, string dir
			, int? lurk = null
			,
			int? life = null
			,
			int? bye = null
			,
			int? waitAftKill = null

		)
		{

			using (var proc = new OnDue(cmd, arg, dir, lurk, life, bye, waitAftKill))
			{
				return proc.cod;
			}
		}

		public static int _ExitCode(PrepI prep
			, int? lurk = null
, int? life = null, int? bye = null
			,
			int? waitAftKill = null

			)
		{
			using (var proc = new OnDue(prep, lurk, life, bye, waitAftKill))
			{
				return proc.cod;
			}

		}

		public static int _Cod_loomAssumeAftLurk(string cmd, string arg, string dir
	, int? lurk = null
	,
	int? loomAftLurk = null
	,
	int? bye = null
	,
	int? waitAftKill = null

)
		{

			using (var proc = new OnDue_loomAftLurk(
				cmd, arg, dir, lurk, loomAftLurk, bye
			))
			{
				return proc.cod;
			}
		}


		public static int _Cod_loomAssumeAftLurk(string cmd
			, int? lurk = null
			,
			int? loomAftLurk = null
			,
			int? bye = null
			,
			int? waitAftKill = null

		)
		{

			return _Cod_loomAssumeAftLurk(cmd, null, null, lurk, loomAftLurk, bye, waitAftKill);
		}
	}


}
