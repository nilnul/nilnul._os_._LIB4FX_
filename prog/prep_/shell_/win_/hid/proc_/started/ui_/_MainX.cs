using nilnul.os.proc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.ui_
{
	/// <summary>
	/// <see cref="os.uis._FindX"/>
	/// </summary>
	public class _MainX
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		static public IntPtr _Handle(ref Process proc)
		{
			return nilnul.os.uis._FindX.Handle(proc);
			int time = nilnul.os.Properties.Settings.Default.procWait4Handle;
			if (time <= 0)
			{
				time = 10 * 1000;
			}

			try
			{
				var handle = proc.WaitForInputIdle(time);
			}
			catch (Exception)
			{

			}


			var win = os.proc_.started.ui_._MainX.Attempted(proc, time);
			return win;


		}



	}

}
