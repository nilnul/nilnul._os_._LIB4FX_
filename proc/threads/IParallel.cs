using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc.threads
{
	internal class IParallel
	{
		///
		/// 
		///
		///
		/*
		 stackoverflow.com/questions/62118565/using-asparallel-on-an-ienumerable-will-it-have-any-benefit-of-parallelism-at
		  
		  answered May 31, 2020 at 16:17
Theodor Zoulias


		 Regarding the query:

GetChars().AsParallel().REST_OF_THE_QUERY
The REST_OF_THE_QUERY will be parallelized. The GetChars will not be parallelized;


A simple experiment shows that with GetChars().AsParallel() System.Threading.Thread.CurrentThread.ManagedThreadId keeps changing inside GetChars, and that the calls into GetChars to get a new element are interlined with execution of the respective REST_OF_THE_QUERY for already fetched elements. However there does appear to be some locking involved, as it would appear that no two threads enter GetChars at the same time. – 
GSerg
 May 31, 2020


For example the code below throws an exception in WinForms:

private void Button1_Click(object sender, EventArgs e)
{
    Control.CheckForIllegalCrossThreadCalls = true;
    int count = GetHandles().AsParallel().Count();
    MessageBox.Show($"Controls: {count}");
}

private IEnumerable<IntPtr> GetHandles()
{
    foreach (Control control in this.Controls)
    {
        yield return control.Handle;
    }
}
InvalidOperationException: Cross-thread operation not valid: Control 'Button1' accessed from a thread other than the thread it was created on.

Without .AsParallel(), no exception is thrown.

		 */
	}
}
