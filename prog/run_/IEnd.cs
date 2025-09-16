namespace nilnul.os.prog.run_
{
	/// <summary>
	/// run the prog till it's finished; it might finish successfuly, or it might be cancelled, aborted, or killed, or in some cases when the killing cannot succeed, discarded whence exception is thrown
	/// </summary>
	/// <remarks>
	/// not include thos program such as os which runs infinitly;
	/// for some program, we just start it and leave it, and not care whether it's ended or not; in that case, it's not <see cref="run_.IEnd"/>, but simply <see cref="prog.IRun"/>
	/// </remarks>
	/// alias:
	///		exit
	///		stop
	///		end
	///		finish
	///		complete
	///		done
	///		
	public interface IEnd:prog.IRun { }
}
