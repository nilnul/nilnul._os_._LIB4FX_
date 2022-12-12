using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_;




namespace nilnul.os.prog.prep_.nonshell_.redirStd_.redirErr_.min.proc_
{
	public class ErrAsyn : Proc
	{



		public ErrAsyn(nilnul.os.prog.prep_.nonshell_.redirStd_.RedirErr info) : base(
			(info)
		)
		{
			reader();
		}




		public ErrAsyn(nilnul.os.prog.prep_.nonshell_.RedirStd info) : this(
			new prog.prep_.nonshell_.redirStd_.RedirErr(info)
		)
		{
		}



		public ErrAsyn(prog.prep_.Nonshell val) : this(new prog.prep_.nonshell_.RedirStd(val))
		{
		}


		public ErrAsyn(ProcessStartInfo val) : this(new prog.prep_.Nonshell(val))
		{
		}



		public ErrAsyn(PrepI prep) : this(new prog.prep_.Nonshell(prep))
		{
		}


		public ErrAsyn(string cmd, string arg = null, string dir = null) : this(
			new Prep(
			cmd, arg, dir
			)
		)
		{
		}

		public ErrAsyn(string cmd, string arg, ShieldI dir) : this(

			cmd, arg, dir.ToString()

			)
		{
		}

		public ErrAsyn(string cmd, string arg, FolderI dir) : this(
			cmd, arg, dir.address.en
		)
		{
		}



		private StringBuilder _errBuilder = new StringBuilder();

		public StringBuilder errBuilder
		{
			get { return _errBuilder; }
			set { _errBuilder = value; }
		}
		public string err
		{
			get
			{
				return _errBuilder.ToString();
			}
		}

		public void reader(DataReceivedEventHandler handler)
		{
			boxed.ErrorDataReceived += handler;
		}
		public void reader()
		{
			reader(
			 new DataReceivedEventHandler((sender, e) =>
				{
					_errBuilder.
						//AppendLine
						Append
						(e.Data);//msDoc says newline is included, but it's not in fact;
					Console.Write($")error: {e.Data};");

					//_errBuilder.Append(e.Data);//If value is null, no changes are made.
				})
			);
		}


	}
}
