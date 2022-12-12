using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.ui.show_
{
	static public class _ToggleX
	{


		static ProcessWindowStyle state = ProcessWindowStyle.Normal;

		/// <summary>
		/// This, however, will not work when the process is started hidden, because the window will not be created and the handle to main window will be zero (invalid).
		/// So, maybe you can start the process normally and then hide it after that. :)
		/// </summary>
		/// <param name="proc"></param>
		static public void Toggle(Process proc)
		{
			if (proc.HasExited)
			{
				return;
				//MessageBox.Show("terminated");
			}

			if (proc.MainWindowHandle != IntPtr.Zero)
			{
				if (state == ProcessWindowStyle.Hidden)
				{
					//normal
					state = ProcessWindowStyle.Normal;
					_ShowWindowX.ShowWindow(proc.MainWindowHandle, 1);
				}
				else if (state == ProcessWindowStyle.Normal)
				{
					//hidden
					state = ProcessWindowStyle.Hidden;
					_ShowWindowX.ShowWindow(proc.MainWindowHandle, 0);
				}
			}

		}
	}
}
