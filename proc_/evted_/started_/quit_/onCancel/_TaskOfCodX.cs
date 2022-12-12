using System.ComponentModel;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using nilnul.str;

namespace nilnul.os.proc_.evted_.started_.quit_.onCancel
{
	/// <summary>
	///  care for the result;
	///		we can cancel the care;
	///  
	/// </summary>
	public static class _TaskOfCodX
	{
		/// <summary>
		/// </summary>
		/// <param name="_proc_evtedStarted"></param>
		/// <param name="cancelProcess">
		/// abort the process
		/// </param>
		/// <param name="lifeGiven"></param>
		/// <param name="extended4user2close"></param>
		/// <param name="waitAftKilling">o
		/// </param>
		public static async Task<int> CodAsyn(
			Process _proc_evtedUnhooked
			,
			CancellationToken cancellationToken = default
		)
		{
			var tcs = new TaskCompletionSource<int>();

			void f(object sender, EventArgs args)
			{
				tcs.TrySetResult(_proc_evtedUnhooked.ExitCode);		//if exited, the task when waited would Garbage collect the "registration" below;

			};

			_proc_evtedUnhooked.Exited += f;

			_proc_evtedUnhooked.Start();

			using var registration = cancellationToken.Register(
				() =>
				{
					#region for perf; but not necessary for soundness
					_proc_evtedUnhooked.Exited -= f;
					_proc_evtedUnhooked.EnableRaisingEvents = false;

					#endregion

					tcs.TrySetCanceled(cancellationToken); // if it's cancelled, exit event would do nothing
				}
			);

			return await tcs.Task; //.ConfigureAwait(false);

		}

	

	}
}
