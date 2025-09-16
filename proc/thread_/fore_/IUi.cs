namespace nilnul.os.proc.thread_
{
	/// <summary>
	/// for an application, one thread is called UI|foreground thread. other threads are background threads.
	/// </summary>
	/// <remarks>
	/// only ui threads would interact with user. So it's better kept not busy;
	/// </remarks>
	interface IUi { }


}
