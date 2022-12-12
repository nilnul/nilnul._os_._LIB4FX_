using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;
using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.started.end_.wait_.timed_
{

	/// <summary>
	/// </summary>
	public static class _AllowEmptyProcX
	{
		/// <summary>
		/// </summary>
		/// <param name="_proc_unwaited"></param>
		/// <param name="cancelProcess">
		/// </param>
		/// <param name="waitAftKilling">o
		/// </param>
		public static bool _Exited_procAssumeLocal(
			Process _proc_unwaited
			,
			int _waitAftKilling_positive
		)
		{
			try
			{
				return _proc_unwaited.WaitForExit((_waitAftKilling_positive));

			}

			catch (Win32Exception)//The wait setting could not be accessed.
			{
				throw;
			}
			catch (Exception x) /*
SystemException
No process Id has been set, and a Handle from which the Id property can be determined does not exist.

-or -

There is no process associated with this Process object.

- or -

You are attempting to call WaitForExit() for a process that is running on a remote computer.This method is available only for processes that are running on the local computer.)
						                   
						                   */
			{
				Trace.TraceError(
					@$"{os._proc._trace._CallSiteX.TxtOfCallSite()}

::::::::::

{x}"
				);
				return true;
			}

	
		}

		public static bool _Exited_procAssumeLocal(
			Process _proc_unwaited
			,
			int? waitAftKilling = null
		)
		{
			return _Exited_procAssumeLocal(
				_proc_unwaited
				,
				os.Properties.SettingsX._WaitAftKilling(waitAftKilling)
			);
		}
	}

}
