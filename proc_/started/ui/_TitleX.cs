using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace nilnul.os.proc_.started.ui
{
	public static class _TitleX
	{
		public static void Vod(Process proc, string title)
		{
			var h = proc_.started.ui_._MainX.Attempted(proc);

			os.ui._TitleX.Void(
				h, title
			);
		}
		public static void TitleNulable(Process proc, string title=null)
		{
			Vod(
				proc, title?? os.proc.prep.Phrase.Singleton.phrase(proc)
			);
		}



		public static void Vod(Process proc)
		{
			Vod(proc, nilnul.os.proc.prep.Phrase.Singleton.phrase(proc));

		}
	}
}