namespace nilnul.os.proc
{
	///
	///
	/// 望文生义，协程是互相协作的自愿让出资源的，而且基本都是用户态自己搞。
	/// 线程是抢占调度的，所以协程资源利用率会高些。
	/// fot coroutine, see nilnul.app

	///<summary>
	/// Multiple threads can run in the context of a process. All threads of a process share its virtual address space. A thread can execute any part of the program code, including parts currently being executed by another thread.
	/// </summary>
	/// <remarks>
	///I/O bound code spends most of its time waiting, for example waiting for data to be returned from another service over the network.
	///threads exist as subsets of a process.
	///Each process has its own memory space. Threads that belong to the same process share the same memory.
	/// </remarks>
	/// A Thread is the smallest unit of execution within a process
	/// vs:
	///		<see cref="os.IProc"/>, which is a heavyweight operation. It takes more time to create and terminate. Context switching is more expensive between processes. Inter-thread communication is faster for threads.
	public interface IThread
	{
	}

}
