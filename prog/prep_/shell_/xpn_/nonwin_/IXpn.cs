﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep_.shell_.nonwin_
{

	/// <summary>
	/// 	If the UseShellExecute property is true or the UserName and Password properties are not null, the CreateNoWindow property value is ignored and a new window is created.
	/// 	.NET Core does not support creating windows directly on Unix-like platforms, including macOS and Linux.This property is ignored on such platforms.
	/// </summary>
	public interface IXpn
	{
		
	}
}

/*
 docs.microsoft.com/en-us/dotnet/api/system.diagnostics.processstartinfo.createnowindow?view=net-6.0

try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = false;
                    // You can start any process, HelloWorld is a do-nothing example.
                    myProcess.StartInfo.FileName = "C:\\HelloWorld.exe";
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                    // This code assumes the process you are starting will terminate itself.
                    // Given that it is started without a window so you cannot terminate it
                    // on the desktop, it must terminate itself or you can do it programmatically
                    // from this application using the Kill method.
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
 */


/*The process is a console application that is being run without a console window. Therefore, the console handle for the application is not set.
This flag is ignored if the application is not a console application, or if it is used with either CREATE_NEW_CONSOLE or DETACHED_PROCESS.*/
