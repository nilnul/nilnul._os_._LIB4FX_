using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace nilnul.os.proc
{
	/// <summary>
	/// processThread;
	/// </summary>
	/// <remarks>
	///When a process starts, the common language runtime automatically creates a single foreground thread to execute application code. Along with this main foreground thread, a process can create one or more threads to execute a portion of the program code associated with the process. These threads can execute either in the foreground or in the background. In addition, you can use the ThreadPool class to execute code on worker threads that are managed by the common language runtime.
	/// </remarks>
	public interface IThreads {

		/// <summary>
		/// When a process starts, the common language runtime automatically creates a single foreground thread to execute application code.
		/// </summary>
		Thread main { get; }

		/// <summary>
		///  Along with this main foreground thread, a process can create one or more threads to execute a portion of the program code associated with the process. These threads can execute either in the foreground or in the background. 
		/// </summary>
		IEnumerable<Thread> extras { get; }

	}
}
