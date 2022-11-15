using System.Collections.Generic;
using System.Diagnostics;

namespace nilnul.os.prog
{
	public abstract class PrepA :
		nilnul.obj.Box1<ProcessStartInfo>
		,
		PrepI
	{
		//static public implicit operator ProcessStartInfo(PrepA prep) {

		//}
		public PrepA(ProcessStartInfo val) : base(val)
		{

		}
		public PrepA():this(new ProcessStartInfo())
		{
		}

		public PrepA(string cmd, string arg=null, string dir=null)
			:this(
				 new ProcessStartInfo() {
					 FileName =cmd, Arguments=arg, WorkingDirectory=(dir is null)?null:nilnul.fs.address._OverlongX.PrependIfNeed(dir)
				 }
			)
		{
		}

		protected PrepA(string cmd, IEnumerable<string> arg, string dir)
			:
			this(

				 new ProcessStartInfo() {
					 FileName =cmd,
					 Arguments=  new _prep._argument.Args(arg).ToString()
					 ,
					 WorkingDirectory=(dir is null)?null:nilnul.fs.address._OverlongX.PrependIfNeed(dir)
				 }

			)
		{

		}
		public PrepA(string cmd, string arg, nilnul.fs.address_.ShieldI dir)
			:this(
				cmd,arg,dir.ToString()
			)
		{
		}

		public PrepA(string cmd, string arg, nilnul.fs.FolderI dir)
			:this(
				cmd,arg,dir.address.en
			)
		{
		}

		protected PrepA(PrepI prep):this(prep.info)
		{
		}
		protected PrepA(PrepA prep):this((PrepI)prep)
		{
		}


		public ProcessStartInfo info => boxed;

		//static public implicit operator ProcessStartInfo(PrepA prep) {
		//	return prep.boxed;
		//}

	}
}
