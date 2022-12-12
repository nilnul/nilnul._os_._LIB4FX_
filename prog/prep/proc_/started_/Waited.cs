using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep.proc_.started_
{
	public class Waited : Started
		,
		IDisposable
	{
	
		public Waited(Waited info) : base(
			info
		)
		{

		}
		

		private Waited(Started _unExited) : base(
			
				_unExited
			
	)
		{
			_unExited.process.WaitForExit();
		}


		public Waited(PrepI info) : this(
			new Started(info)
		)
		{

		}

		public Waited(PrepA info) : this(
			(PrepI)info
		)
		{

		}
		public Waited(Prep info) : this(
			(PrepI)info
		)
		{

		}
		public Waited(ProcessStartInfo info) : this(
			new Prep(info)
		)
		{

		}

		public Waited(string cmd, string arg = null, string dir = null) : this(
			new Prep(
			cmd, arg, dir
			)
		)
		{
		}

		public int cod
		{
			get
			{
				return boxed.ExitCode;
			}
		}



	

	}
}
