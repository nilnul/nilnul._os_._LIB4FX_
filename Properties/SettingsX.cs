using nilnul.os.proc_.started_.unwaited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.Properties
{
	static public class SettingsX
	{
		/// <summary>
		/// </summary>
		/// <param name="life4proc"></param>
		/// <returns></returns>
		public static int _Life4proc(

			int? life4proc = null

		)
		{
			return life4proc
					??
					nilnul.func._TryX.Try(
						() =>
						{
							try
							{
								return nilnul.win.Properties.Settings.Default?.procLife;
							}
							catch (Exception)
							{
								return null;
							}
						}
					)

					??

					int.Parse(
						(string)
						nilnul.win.Properties.Settings.Default.Properties[nameof(nilnul.win.Properties.Settings.Default.procLife)].DefaultValue

					)

				;
		}

		public static int _WaitAftKilling(

			int? waitAftKilling = null

		)
		{
			return waitAftKilling
					??
					nilnul.func._TryX.Try(
						() =>
						os.proc_.started._due.Settings1.Default?.waitAftKill

					)

					??

					int.Parse(
						(string)
						os.proc_.started._due.Settings1.Default.Properties[nameof(os.proc_.started._due.Settings1.Default.waitAftKill)].DefaultValue

					)

				;
		}

		public static int _Minimal4usr2close(
			int? minimum4user2close = null
		)
		{
			return minimum4user2close ?? proc_.started._due.Settings1.Default.minimum4user2close;
		}
		public static int _Extend4usr2close(

			int? extended4user2close = null
		)
		{
			return extended4user2close ?? nilnul.win.Properties.Settings.Default.procBye;
		}

	}
}
