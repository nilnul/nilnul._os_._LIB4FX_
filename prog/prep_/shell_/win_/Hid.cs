using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;
namespace nilnul.os.prog.prep_.shell_.win_
{
	/*
	 * stackoverflow.com/questions/16185217/c-sharp-process-mainwindowhandle-always-returns-intptr-zero
	 * The value is also zero for processes that have been hidden, that is, processes that are not visible in the taskbar. This can be the case for processes that appear as icons in the notification area, at the far right of the taskbar.

If you have just started a process and want to use its main window handle, consider using the WaitForInputIdle method to allow the process to finish starting, ensuring that the main window handle has been created. Otherwise, an exception will be thrown.*/

	/// A process has a main window associated with it only if the process has a graphical interface. If the associated process does not have a main window, the MainWindowHandle value is zero. The value is also zero for processes that have been hidden, that is, processes that are not visible in the taskbar.
	/// If a window is hidden, it is effectively disabled
	///
	///
	///
	/// 
	/// <summary>
	/// 
	/// </summary>

	[Obsolete("once hid, will not be able to be reshown;")]

	public class Hid : Win
	{
		public Hid(Hid nonShell):base(nonShell)
		{

		}

		public Hid(Win nonShell):base( nonShell )
		{
			nonShell.info.WindowStyle = ProcessWindowStyle.Hidden;

		}

		public Hid(Shell nonShell):this( new Win( nonShell ) )
		{

		}
	

		public Hid(ProcessStartInfo val) : this( new Shell( val ))
		{
		}
		public Hid(PrepI prep) : this(new Shell(prep))
		{
		}

		public Hid(PrepA prep) : this((PrepI)prep)
		{
		}

		public Hid():this(new ProcessStartInfo())
		{
		}

		public Hid(string cmd, string arg = null, string dir = null) : this(
			new ProcessStartInfo()
			{
				FileName=cmd
				,
				Arguments=arg,
				WorkingDirectory=dir

			}
			)
		{
		}

		public Hid(string cmd, string arg, ShieldI dir) : this(cmd, arg, dir.ToString())
		{
		}

		public Hid(string cmd, string arg, FolderI dir) : this(cmd, arg, dir.address.en)
		{
		}

		
	}
}
