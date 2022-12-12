using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;




namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr.proc_.errAsyn_
{
	/// <summary>
	/// useful in logging if we write to file
	/// </summary>
	///
	[Obsolete("weird that the lines read in are missing line breaks;" )]
	public class StdAsyn : ErrAsyn
	{
		//public Started(Started started) : base(started)
		//{
		//}
		//public Started(ErrAsyn started) : base(started)
		//{
		//	boxed.Start();
		//}

		public StdAsyn(RedirErr info) : base(
			(info)
		)
		{
			readStd();
		}
	


		public StdAsyn(RedirStd info) : this(
			new RedirErr(info)
		)
		{
		}
	


		public StdAsyn(Nonshell val) : this(new RedirStd(val))
		{
		}
	

		public StdAsyn(PrepI prep) : this(new Nonshell(prep))
		{
		}


		public StdAsyn(Prep val) : this(new Nonshell(val))
		{
		}

	

		public StdAsyn(ProcessStartInfo val) : this(new Nonshell(val))
		{
		}


		public StdAsyn(string cmd, string arg = null, string dir = null) : this(
			new Prep(
			cmd, arg, dir
			)
		)
		{
		}

		public StdAsyn(string cmd, string arg, ShieldI dir) : this(
			cmd, arg, dir?.ToString()
			
			)
		{
		}

		public StdAsyn(string cmd, string arg, FolderI dir) : this(
			
			cmd, arg, dir?.ToString()
			
			)

		{
		}
		private StringBuilder _stdBuilder = new StringBuilder();

		public StringBuilder stdBuilder
		{
			get { return _stdBuilder; }
			set { _stdBuilder = value; }
		}
		public string std
		{
			get
			{
				return _stdBuilder.ToString();
			}
		}

		public void readStd(DataReceivedEventHandler handler)
		{
			boxed.OutputDataReceived += handler;
		}
		public void readStd()
		{
			readStd(
			 new DataReceivedEventHandler((sender, e) =>
			 {
				 _stdBuilder.AppendLine(e.Data); // ms doc says newline is in data; but in fact it's not
				// _stdBuilder.Append(e.Data);

			 })
			);
		}

	}
}
