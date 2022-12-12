using nilnul.obj.str;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.act_.bottom_.inact1min_
{
	/// <summary>
	/// make this a task
	/// </summary>
	///
	[Obsolete("for notepad, a default ide window is displayed")]
	public static class _Title4multiX
	{

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public static void Act(ref Process proc, string title = null, int wait4input = 1000)
		{
#if Symbol
			Debug.WriteLine("show window...");

#endif

			try
			{
				//proc.WaitForInputIdle(
				//	wait4input
				//);
				/*C:\Program Files\Git\bin\git.exe commit --allow-empty  -m"add and commit all for backup"
				   D:\r\
:::
System.InvalidOperationException: WaitForInputIdle 失败。  这可能是因为该进程没有图形界面。
   在 System.Diagnostics.Process.WaitForInputIdle(Int32 milliseconds)
   在 nilnul.os.prog.prep_.shell_.win_.hid.proc_.started.act_.bottom_.inact1min_._TitleX.Act(Process& proc, String title, Int32 wait4input) 位置:行号 21*/

			}
			catch (InvalidOperationException x)
			{
				os.proc.act_._TraceAsErrX.TraceAsErr(ref proc, x);
				//return;

			}
			var threadWin = os.prog.prep_.shell_.win_.hid.proc_.started._UiX.ThreadWinEs(proc);

			var t = title ?? nilnul.os.proc.prep.Phrase.Singleton.phrase(proc
						);

			threadWin.Each(
				w =>
				{
					os.ui.act_.show_._Min1inactiveX.Act(
						w
					);
					nilnul.os.ui_.nonnil._TitleX.Act(
						w, t
									  
					); 
				}
			);
			//Inactive1min.Singleton.act(ref proc);
#if Symbol
			Debug.WriteLine("show title...");

#endif



			//nilnul.os.proc.act_.ui_.title_._DirFirstX.Void_ofHandleNotNil(
			//	proc
			//	,
			//	title
			//);
		}
}
}
