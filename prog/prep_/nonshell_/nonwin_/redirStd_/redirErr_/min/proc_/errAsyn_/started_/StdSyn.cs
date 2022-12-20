using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;



namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_.min.proc_.errAsyn_.started_
{
	public class StdSyn : Started
		
	{

		public StdSyn(nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info) : base(
			(info)
		)
		{
			readAll();


		}

		public StdSyn(nilnul.os.prog.prep_.nonshell_.RedirStd info) : this(
			new prog.prep_.nonshell_.redirStd_.RedirErr
			(info)
		)
		{
		}

		public StdSyn(prog.prep_.Nonshell val) : this(
			new prog.prep_.nonshell_.RedirStd(val))
		{
		}


		public StdSyn(PrepI val) : this(
			new prog.prep_.Nonshell(val)

			)
		{
		}
		public StdSyn(PrepA val) : this(
			(PrepI)(val)

			)
		{
		}
	
		public StdSyn(ProcessStartInfo val) : this(
			new prog.prep_.Nonshell(val)
		)
		{
		}


		public StdSyn(string cmd, string arg = null, string dir = null) :
			this(
			new prog.Prep(cmd, arg, dir)
		)
		{
		}

		public StdSyn(string cmd, string arg, ShieldI dir) :
				this(
			new prog.Prep(cmd, arg, dir)
		)

		{
		}

		public StdSyn(string cmd, string arg, FolderI dir) :
				this(
			new prog.Prep(cmd, arg, dir)
		)


		{
		}
		private string _msg;

		public string msg
		{
			get { return _msg; }
			set { _msg = value; }
		}

		private void readAll()
		{
			#region read all
			// To avoid deadlocks, always read the output stream first and then wait.  
			_msg = boxed.StandardOutput.ReadToEnd();
			//return;
			#endregion

	

		}




	}
}
