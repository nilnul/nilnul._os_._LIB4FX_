using nilnul.os.proc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_.ui_.nonnil.act_.normal_
{
	/// <summary>
	/// </summary>
	public class _Inactive1min_uiAssumeNonnil : ActI
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public  void act(ref Process proc)
		{
			os.ui_.hid.show_.normal_._Min1inactiveX._assumeNonnil(proc.MainWindowHandle);

		}

		static public _Inactive1min_uiAssumeNonnil Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<_Inactive1min_uiAssumeNonnil>.Instance;
			}
		}

	}

}
