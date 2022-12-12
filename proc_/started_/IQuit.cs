namespace nilnul.os.proc_.started_
{
	/// <summary>
	/// exited, or we leave it by throw an exception of timeout;
	/// </summary>
	/// vs:
	///		<see cref="proc_.IStarted"/>
	///			we don't care about whether it's quit
	///	alias:
	///		quit
	///			let's call it quit
	///				we leave the job, done or undone but not cared
	///				
	///		untended
	public interface IQuit { }
}
