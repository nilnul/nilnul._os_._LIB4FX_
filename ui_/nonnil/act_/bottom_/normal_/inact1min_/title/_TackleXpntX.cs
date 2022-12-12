using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.ui_.nonnil.act_.bottom_.normal_.inact1min_.title
{
	/// <summary>
	/// </summary>
	public static class _TackleXpnX
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public static void Act(IntPtr proc, string title=null)
		{
			try
			{

				_TitleX.Act( proc, title);
			}
			catch (Exception e)
			{
				Trace.TraceError($"ui handle:{proc} cannot be set title after being brought to bootom as normal inact1min;");
				
			}

		}
	}
}
