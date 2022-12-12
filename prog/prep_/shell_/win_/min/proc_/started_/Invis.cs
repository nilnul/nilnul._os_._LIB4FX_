using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;





namespace nilnul.os.prog.prep_.shell_.win_.min.proc_.started_
{
	/// <summary>
	/// </summary>
	///
	public class Invis : Started
	{
		//public Started(Started started) : base(started)
		//{
		//}
		//public Started(ErrAsyn started) : base(started)
		//{
		//	boxed.Start();
		//}

		/// <summary>
		/// cache the window handle, as Process.MainWindowHandle is zero if window is hide
		/// </summary>
		private IntPtr _ui;

		public IntPtr ui
		{
			get { return _ui; }
			set { _ui = value; }
		}

		//private int? _wait4handle;

		//public int? wait4handle
		//{
		//	get { return _wait4handle; }
		//	set { _wait4handle = value; }
		//}


		public Invis(nilnul.os.prog.prep_.shell_.win_.Min info, int? wait4handle = null) : base(
			(info)
		)
		{
			_ui = os.proc_.started.ui_._MainX.Attempted(boxed);


			nilnul.os.ui.show_._HideX.Hide(_ui);//.proc.act_.ui_.Hide.Singleton.act(ref p);
		}


		public Invis(nilnul.os.prog.prep_.shell_.Win info, int? wait4handle = null) : this(
			new Min(info), wait4handle
		)
		{
		}


		//public Invis(End info):base(info)
		//	{
		//	}

		public Invis(Shell val, int? wait4handle = null) : this(new os.prog.prep_.shell_.Win(val), wait4handle)
		{
		}

		public Invis(ProcessStartInfo val, int? wait4handle = null) : this(new prog.prep_.Shell(val), wait4handle)
		{
		}

		public Invis(PrepI prep, int? wait4handle = null) : this(new prog.prep_.Shell(prep), wait4handle)
		{
		}

		public Invis(PrepA prep, int? wait4handle = null) : this((PrepI)(prep), wait4handle)
		{
		}

		public Invis(Prep prep, int? wait4handle = null) : this((PrepI)(prep), wait4handle)
		{
		}


		public Invis(string cmd, string arg = null, string dir = null, int? wait4handle = null) : this(
			new prog.Prep(
			cmd, arg, dir
			), wait4handle
		)
		{
		}

		public Invis(string cmd, string arg = null, ShieldI dir = null, int? wait4handle = null) : this(
			cmd, arg, dir?.ToString(), wait4handle
			)
		{
		}

		public Invis(string cmd, string arg = null, FolderI dir = null, int? wait4handle = null) : this(
			cmd, arg, dir?.ToString(), wait4handle
		)
		{
		}
	}
}
