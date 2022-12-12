using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os
{
	public abstract class ProcA
		:
		nilnul.obj.Box1<Process>
		,
		ProcI
		,IDisposable
	{
		//public ProcA(Process val) : base(val)
		//{
		//}
		public ProcA(Process val) : base(val)
		{
		}

		public ProcA(ProcessStartInfo info):this (
			new Process() {
			StartInfo = info
			}
		)
		{
		}
		public ProcA(string cmd, string arg = null, string dir = null)
			: this(
				 new ProcessStartInfo()
				 {
					 FileName = cmd,
					 Arguments = arg,
					 WorkingDirectory = dir
				 }
			)
		{
		}

		public ProcA(string cmd, string arg, nilnul.fs.address_.ShieldI dir)
			: this(
				cmd, arg, dir.ToString()
			)
		{
		}

		public ProcA(string cmd, string arg, nilnul.fs.FolderI dir)
			: this(
				cmd, arg, dir.address.en
			)
		{
		}


		public ProcA(prog.PrepI prep):this( prep.info )
		{

		}
		public ProcA(prog.PrepA prep):this( (prog.PrepI) prep)
		{

		}


		public Process process => boxed;

		public override string ToString()
		{
			return nilnul.os.proc.prep.Phrase.Singleton.phrase(boxed);
		}

		//static public implicit operator Process(ProcA proc) {
		//	return proc.boxed;
		//}

		static public Process Create(prog.PrepI prep) {
			return new Process() { StartInfo = prep.info };
		}

		#region IDisposable Support
		private bool disposedValue = false; // 要检测冗余调用

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					boxed.Dispose();
					// TODO: 释放托管状态(托管对象)。
				}
				//boxed = null;
				// TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
				// TODO: 将大型字段设置为 null。

				disposedValue = true;
			}
		}

		// TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
		// ~ProcA_box()
		// {
		//   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
		//   Dispose(false);
		// }

		// 添加此代码以正确实现可处置模式。
		public void Dispose()
		{
			// 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
			Dispose(true);
			// TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
			// GC.SuppressFinalize(this);
		}
		#endregion
	}




}
