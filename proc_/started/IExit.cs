namespace nilnul.os.proc_.started
{
	/// <summary>
	/// make sure the process is exited/ended;
	/// </summary>
	/// <remarks>
	/// by killing it and wait for it to exit. indefinite waitting might happen, even we are killing it; So we may need to throw an exception if the killing is timeout;
	/// </remarks>
	public interface IExit { }

}
