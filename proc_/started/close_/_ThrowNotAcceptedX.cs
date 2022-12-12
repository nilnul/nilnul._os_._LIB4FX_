using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.close_
{

	/// <summary>
	/// </summary>
	public static class _ThrowNotAcceptedX
	{

		public static   bool  Exited(
			Process proc
		)
		{
			bool requestSent = false;
			try
			{
			 	requestSent = proc.CloseMainWindow(); 
			}
			catch (InvalidOperationException e) /*The process has already exited. 
-or- No process is associated with this Process object.*/
			{
					return  true; 
			}
			if (!requestSent)
			{
				throw new xpn_.NotAccepted(
					os.proc.prep.Phrase.Singleton.phrase(proc)
				);
			}
			return false;


		}

	

	}
}
