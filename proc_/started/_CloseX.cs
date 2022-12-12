using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started
{

	/// <summary>
	/// </summary>
	public static class _CloseX
	{

		public static bool Exited(
			Process proc
		)
		{
			try
			{
				proc.CloseMainWindow();
			}
			catch (InvalidOperationException e) /*The process has already exited. 
-or- No process is associated with this Process object.*/
			{
				return true;
			}
			return false;



		}

		public static void Vod(
			Process proc
		)
		{
			try
			{
				proc.CloseMainWindow();
			}
			catch (InvalidOperationException e) /*The process has already exited. 
-or- No process is associated with this Process object.*/
			{
			}



		}



	}
}
