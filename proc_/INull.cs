namespace nilnul.os.proc_
{
	/// <summary>
	/// when you start a nonprog file:<see cref="fs.path_.INonprog"/>, it would be started in shell; and if the shell finds such program is runing , it may reuse the current process, and no new process is started hence the returned process is null;
	/// </summary>
	public interface INull :IProc{ }
}
