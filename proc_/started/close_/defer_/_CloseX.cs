using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.os.proc_.started.quit_._abort._kill
{

	/// <summary>
	/// a timespan is allowed to let it die by itself, not by being killed; 
	/// </summary>
	public static class _CloseX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="proc"></param>
		/// <param name="extended4user2close">
		/// given some time for it to suicide;
		/// </param>
		/// <param name="processExitedSignal">
		/// we don't need to do suicide anymore cuz, say, the process has been ended by, say, "Wait" in the main thread if this is in a timeout supervising thread;
		/// </param>
		/// <returns></returns>
		public static async Task<bool> EndedAsyn(
			Process proc
			,
			CancellationToken processExitedSignal
			,
			int minimum4user2close
		)
		{
			//if (proc.HasExited) { return; }

			//(cancel).ThrowIfCancellationRequested();
			bool requestSent = false;
			//processWaitedSignal.ThrowIfCancellationRequested();
			try
			{
				//if (processWaitedSignal.IsCancellationRequested)
				//{
				//	return true;
				//}
				requestSent = proc.CloseMainWindow(); //here the process exited and hence cancel is not needed;
			}
			catch (InvalidOperationException e) /*The process has already exited. 
-or- No process is associated with this Process object.*/
			{
				try
				{
					if (proc.HasExited)
					{
						return true;
					}
					else
					{
						return false;
					}

				}
				catch (InvalidOperationException)/*-or- No process is associated with this Process object.*/
				{

					return true;
				}
			}

			if (requestSent)
			{

				await Task.Delay(
						minimum4user2close
						,
						processExitedSignal
				).ContinueWith(t => { });

				if (processExitedSignal.IsCancellationRequested)
				{
					return true;
				}
				// if exitd an exception would be thrown;
				//processWaitedSignal.ThrowIfCancellationRequested();

				try
				{
					if (proc.HasExited) { return true; }
					else
					{
						return false;
					}

				}
				catch (InvalidOperationException)
				{

					return true;
				}
				//wait for some time
				//(cancel).ThrowIfCancellationRequested();
				//if (proc.HasExited) { return; }
			}
			//else/*if the associated process does not have a main window or if the main window is disabled (for example if a modal dialog is being shown).*/
			//{

			//}
			return false;
		}

		public static bool Ended(
			Process proc
			,
			CancellationToken processWaitedSignal
			,
			int minimum4user2close
		)
		{
			//if (proc.HasExited) { return; }

			//(cancel).ThrowIfCancellationRequested();
			bool requestSent = false;
			//processWaitedSignal.ThrowIfCancellationRequested();
			try
			{
				requestSent = proc.CloseMainWindow(); //here the process exited and hence cancel is not needed;
			}
			catch (InvalidOperationException e) /*The process has already exited. 
-or- No process is associated with this Process object.*/
			{
				try
				{
					if (proc.HasExited)
					{
						return true;
					}
					else
					{
						return false;
					}

				}
				catch (InvalidOperationException)/*-or- No process is associated with this Process object.*/
				{

					return true;
				}
			}

			if (requestSent)
			{

				try
				{
					Task.Delay(
						   minimum4user2close
						   ,
						   processWaitedSignal
				   ).ContinueWith(t => { }).Wait(
//processWaitedSignal
					);
					if (processWaitedSignal.IsCancellationRequested)
					{
						return true;
					}

				}
				catch (AggregateException ex)
				{
					ex.Handle(
						ttt=> ttt is TaskCanceledException 
					);
					
					return true;
				}

				// if exitd an exception would be thrown;
				//processWaitedSignal.ThrowIfCancellationRequested();

				try
				{
					if (proc.HasExited) { return true; }
					else
					{
						return false;
					}

				}
				catch (InvalidOperationException)
				{

					return true;
				}
				//wait for some time
				//(cancel).ThrowIfCancellationRequested();
				//if (proc.HasExited) { return; }
			}
			//else/*if the associated process does not have a main window or if the main window is disabled (for example if a modal dialog is being shown).*/
			//{

			//}
			return false;
		}

	}
}
