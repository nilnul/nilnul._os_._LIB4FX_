using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os
{
	/*
You cannot re-use a Process object. The Process class behaves like all of the other .NET classes that wrap an operating system object. Like Socket, Bitmap, Mutex, FileStream, etcetera. They are tiny little cookies that are very cheap to bake and take very little space on the GC heap. They track the lifetime of the underlying OS object carefully, once the object is dead, the .NET wrapper object is no longer useful either.

The Process class signals that the cookie was eaten with its Exited event and HasExited property. It has some post-bite properties that are useful, ExitCode and ExitTime.

But that's where it ends, if you want to create another process then you have to bake another cookie. Simple to do with the new keyword or the Start() factory function. Don't try to optimize it, there's no point and it can't work. Re-using ProcessStartInfo is fine, it is not a wrapper class.

answered May 18, 2015 at 8:21
Hans Passant	 */

	/*
	 
	 For Process.Start(), it says:

Return Value Type: System.Boolean true if a process resource is started; false if no new process resource is started (for example, if an existing process is reused).

So it says if an existing process is reused, this is entirely up to the application being started or the method of starting it.

	You can technically get a false return when you use ProcessStartInfo.UseShellExecute = true (the default) and you launch the process by passing a document filename. And the shell is somehow able to figure out to pass the document open request to an already running instance of the process.

The only documented case of this is opening a web page in Internet Explorer. There might be other ones, probably having something to do with legacy DDE activation. That's a guess.

This is otherwise a specific case of a general problem with Process.Start(), there are lots of single-instance apps around. The Office apps as the most common example. The most typical behavior you'd observe is that the process very quickly terminates again. It just detected that the app was already running and used process-interop to ask the running instance to open the document.
	
	 
	 In addition, Start may return a non-null Process with its HasExited property already set to true. In this case, the started process may have activated an existing instance of itself and then exited.*/

	/*f I read this correctly, all you need to do is create a new instance of ProcessStartInfo and then if there is a Process running, it reuses that.

Use this overload to start a process resource by specifying a ProcessStartInfo instance. The overload associates the resource with a new Process component. If the process is already running, no additional process resource is started. Instead, the existing process resource is reused and no new Process component is created. In such a case, instead of returning a new Process component, Start returns null to the calling procedure.

http://msdn.microsoft.com/en-us/library/0w4h05yb.aspx (First line under remarks)*/
	public interface IProc
	{
	}
}
