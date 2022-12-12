
using nilnul.os.prog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started_
{
	public class Doodle : Started

	{


		public Doodle(Doodle info) : base(
			info
		)
		{

		}

		public Doodle(Started info, CancellationToken  cancel=default, int? life = null, int? bye = null) : base(

			info
		)
		{
			end(cancel,life, bye);
		}



		public Doodle(ProcessStartInfo info, CancellationToken  cancel=default, int? life = null, int? bye = null) : this(
			new Started(info),cancel, life, bye
		)
		{

		}

		public Doodle(PrepI info, CancellationToken  cancel=default, int? life = null, int? bye = null) : this(
			info.info,cancel, life, bye
		)
		{

		}
		public Doodle(PrepA info, CancellationToken  cancel=default, int? life = null, int? bye = null) : this(
			(PrepI)info,cancel, life, bye
		)
		{

		}

		public Doodle(string cmd, string arg = null, string dir = null, CancellationToken  cancel=default, int? life = null, int? bye = null) : this(
			new Prep( cmd, arg, dir),cancel,life,bye
		)
		{
		}

		//public Task killTask;

		private void end(CancellationToken  cancel=default, int? life = null, int? bye = null)
		{

			 os.proc_.started.cull_.delayed_._CancellableX._Exit0cancelledAsTask(
				 boxed
				 , life
				 , bye
				 , cancel
				);


		


		}

	}
}
