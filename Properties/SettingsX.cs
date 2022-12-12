using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.duo;
using nilnul.os.proc_.started_.unwaited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.Properties
{
	public class SettingsX
	{
		/// <summary>
		/// the process 's handle is not immediatly set; may later, the Os gives a handle;
		/// </summary>
		//static public string procWait4Handle { get; }

			/// <summary>
			/// </summary>
			/// <param name="life4proc"></param>
			/// <returns></returns>
			public static int _Life4proc(

				int? life4proc = null

			)
			{
				if (life4proc is not null) { return life4proc.Value; }

				var t = /*life4proc					??*/
						nilnul.func._TryX.Try(
							() =>
							{
								try
								{
									return nilnul.os.Properties.Settings.Default?.procLife;
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
							nilnul.os.Properties.Settings.Default.Properties[nameof(nilnul.os.Properties.Settings.Default.procLife)].DefaultValue

						)

					;
				const int min = 60 * 1000;
				if (t < min)
				{
					t = min;
					//t = int.Parse(
					//		(string)
					//		nilnul.os.Properties.Settings.Default.Properties[nameof(nilnul.os.Properties.Settings.Default.procLife)].DefaultValue

					//	);
				}
				return t;
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

			public static int _RunAftCancel(

				int? runAftCancel0 = null

			)
			{
				return runAftCancel0
						??

					os.Properties.Settings.Default.proc_runAftCancel



					;
			}

			public static int _Minimal4usr2close(
				int? minimum4user2close = null
			)
			{
				return minimum4user2close ?? proc_.started._due.Settings1.Default.minimum4user2close;
			}

			public static int _Lurk(
				int? minimum4user2close = null
			)
			{
				const int min = 1 * 1000;
				var t = minimum4user2close ?? nilnul.os.Properties.Settings.Default.procLaterPop;
				if (t < min)
				{
					t = min;
					//t = int.Parse(
					//		(string)
					//		nilnul.os.Properties.Settings.Default.Properties[nameof(nilnul.os.Properties.Settings.Default.procLaterPop)].DefaultValue

					//	);
				}
				return t;
			}

			public static int _Extend4usr2close(

				int? extended4user2close = null
			)
			{
				return extended4user2close ?? nilnul.os.Properties.Settings.Default.procBye;
			}

		/// <summary>
		/// to get the ui handle of the proc; the ui initialization might need some time;
		/// </summary>
		/// <param name="extended4user2close"></param>
		/// <returns></returns>
			public static int _ProcWait4handle(

				int? extended4user2close = null
			)
			{
				return extended4user2close ?? nilnul.os.Properties.Settings.Default.procWait4Handle;
			}



		}
	}
