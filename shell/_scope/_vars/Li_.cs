using nilnul.os.shell._scope._var.attr_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.shell._scope._vars
{
	/*
	 
Precedence
When a new process is started, the variables will be loaded in the following order:

System Environment Variables
Shell Variables (per user)
User Environment Variables
Shell Variables (other)
After the process has started, additional shell variables can be defined with SET, these will be available only to the current CMD shell session, but they will take precedence over any environment variables with the same name.

For example, if the SET command is used to modify the PATH, or if it is removed completely with PATH ; that will affect the current process, but not any other programs or CMD sessions opened before or after the current one.

This precedence is important to understand because if you try to set a System Environment variable PATH = %APPDATA%;C:\Windows, it will fail because the %APPDATA% Shell variable is not created until after the System environment variables are imported to the session.
However, you can use %APPDATA% to build a User environment variable PATH.

Running the SET command with no options will display all Shell variables plus all User and System Environment variables, in other words every variable available to be read by that session. In PowerShell the same list is available via the env: drive	 
	 */
	/*
	Pass variables between batch scripts
There are several ways to pass values between batch files, or between a batch file and the command line, see the CALL and SETLOCAL pages for full details.

A child process by default inherits a copy of all environment variables from its parent, this makes environment variables unsuitable for storing secret information such as API keys or user passwords, especially in rare occasions like crashes where a crash log will often include the full OS environment at the time of the crash. PowerShell/Get-Credential is a more secure approach.

If Command Extensions are disabled, the following dynamic variables will be not accessible:
%CD% %DATE% %TIME% %RANDOM% %ERRORLEVEL% %CMDEXTVERSION% %CMDCMDLINE% %HIGHESTNUMANODENUMBER% 
	 */
	/// this is a list of names, each of which is annotated;
	/// for a list, the best storage format wouldnot be Csv, as it's a 2d table, not a 1d list;
	/// we might consider using a txt of lines, each of which is a key annotated with a description;
	/// As the key is nom(without punc), the enum would be the simplest form, simpler than txt of line;
	///		even the key is beyond nom, we can use annotation(description attributation)
	/// <summary>
	/// Environment variables are stored in the registry:
	/// User Environment Variables: HKCU\Environment
	/// System Environment Variables: HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Environment
	/// By default, files stored under Local Settings do not roam with a roaming profile.

	///Dynamic environment variables are computed each time the variable is expanded, this makes them inherently read-only.
	///When all variables are listed with SET, these will not appear in the list.


	///Volatile variables are defined under the registry: HKCU\Volatile Environment
	///Do not attempt to directly SET a volatile variable, while you could change them, the system will overwrite them with newly derived values.The majority of volatile variables are CMD shell variables, so like all CMD shell variables they are stored in memory only.
	/// </summary>
	/// <remarks></remarks>
	///

	public enum Li_
	{
		/// <summary>
		/// C:\ProgramData
		/// Predefined machine-wide system variable.
		/// </summary>
		///
		[Shell]
		ALLUSERSPROFILE
			,
		/// <summary>
		/// C:\Users\{username}\AppData\Roaming
		/// </summary>
		[Logon, Shell]

		AppData
			,
		/// <summary>
		/// The current directory (string).
		/// </summary>
		[Dynamic, Shell]
		CD
			,
		/// <summary>
		/// Terminal servers only - the ComputerName of a remote host.
		/// </summary>
		[Logon, Shell]
		ClientName
			,
		/// <summary>
		/// The current Command Processor Extensions version number. (NT = "1", Win2000+ = "2".)
		/// </summary>
		[Dynamic, Shell]
		CmdExtVersion
			,
		/// <summary>
		/// The original command line that invoked the Command Processor.
		/// </summary>
		[Dynamic, Shell]
		CmdCmdLine
			,
		/// <summary>
		/// C:\Program Files\Common Files
		/// </summary>
		[Shell]
		CommonProgramFiles
			,
		/// <summary>
		/// eg:
		/// C:\Program Files (x86)\Common Files
		/// Description must be used for the nom;
		/// </summary>
		[Description("COMMONPROGRAMFILES(x86)")]
		[Shell]
		COMMONPROGRAMFILES_x86_
			,
		/// <summary>
		/// {computername}
		/// </summary>
		[Shell]
		ComputerName
			,
		/// <summary>
		/// C:\Windows\System32\cmd.exe
		///		or
		///	if running a 32 bit WOW -
		///		C:\Windows\SysWOW64\cmd.exe
		/// </summary>
		/// <remarks>
		///	Comspec is used whenever the command shell spawns a new process, e.g. the FOR command, if comspec is not defined those processes will fail to launch.
		/// </remarks>
		///
		[Sys]
		ComSpec
			,
		/// <summary>
		/// The current date using same region specific format as DATE.
		/// </summary>
		[Dynamic, Shell]
		DATE
			,
		/// <summary>
		/// The current ERRORLEVEL value, automatically set when a program exits.
		/// </summary>
		[Dynamic, Shell]
		ErrorLevel
			,
		/// <summary>
		/// Internet Explorer
		/// Default
		/// These are undocumented variables for the Edge browser in Windows 10.
		/// </summary>
		///
		[Shell]
		FPS_BROWSER_APP_PROFILE_STRING
			,
		/// <summary>
		/// Internet Explorer
		/// Default
		/// These are undocumented variables for the Edge browser in Windows 10.
		/// </summary>
		///
		[Shell]
		FPS_BROWSER_USER_PROFILE_STRING
			,
		/*
		 The traditional model for multiprocessor architecture is symmetric multiprocessor (SMP). In this model, each processor has equal access to memory and I/O. As more processors are added, the processor bus becomes a limitation for system performance.

System designers use non-uniform memory access (NUMA) to increase processor speed without increasing the load on the processor bus. The architecture is non-uniform because each processor is close to some parts of memory and farther from other parts of memory. The processor quickly gains access to the memory it is close to, while it can take longer to gain access to memory that is farther away.

In a NUMA system, CPUs are arranged in smaller systems called nodes. Each node has its own processors and memory, and is connected to the larger system through a cache-coherent interconnect bus.

The system attempts to improve performance by scheduling threads on processors that are in the same node as the memory being used. It attempts to satisfy memory-allocation requests from within the node, but will allocate memory from other nodes if necessary. It also provides an API to make the topology of the system available to applications. You can improve the performance of your applications by using the NUMA functions to optimize scheduling and memory usage.
		 */
		/// <summary>
		/// The highest NUMA node number on this computer.
		/// </summary>
		/// 
		[Dynamic(true), Shell]
		HighestNumaNodeNumber
			,
		/// <summary>
		/// C:
		/// </summary>
		[Logon, Shell]
		HomeDrive
			,
		/// <summary>
		/// \Users\{username}
		/// </summary>
		///
		[Logon, Shell]
		HomePath
			,
		/// <summary>
		/// Network home folder.
		/// </summary>
		///
		[Logon]
		HomeShare

		,
		/// <summary>
		/// C:\Users\{username}\AppData\Local
		/// </summary>
		[Logon, Shell]
		LOCALAPPDATA
			,
		/// <summary>
		/// \\{domain_logon_server}
		/// </summary>
		[Logon, Shell]
		LOGONSERVER
			,
		/// <summary>
		/// The Number of processors running on the machine.
		/// </summary>
		[Sys]

		NUMBER_OF_PROCESSORS
			,
		/// <summary>
		///OneDrive synchronisation folder. 
		/// </summary>
		[Sys]
		OneDrive
			,
		/// <summary>
		/// Operating system on the user's workstation.
		/// </summary>
		[Sys]
		OS
			,
		/// <summary>
		/// C:\Windows\System32\;C:\Windows\;C:\Windows\System32\Wbem;{plus program paths}
		/// </summary>
		[Usr, Sys]
		Path
			,
		/// <summary>
		/// .COM; .EXE; .BAT; .CMD; .VBS; .VBE; .JS ; .WSF; .WSH; .MSC
		/// Determine the default executable file extensions to search for and use, and in which order, left to right.
		/// The syntax is like the PATH variable - semicolon separators.
		/// </summary>
		[Sys]
		PathExt
			,
		/// <summary>
		/// AMD64/IA64/x86 This doesn’t tell you the architecture of the processor but only of the current process, so it returns "x86" for a 32 bit WOW process running on 64 bit Windows. See detecting OS 32/64 bit
		/// </summary>
		[Sys]
		PROCESSOR_ARCHITECTURE
			,
		/// <summary>
		/// =%PROCESSOR_ARCHITECTURE% (but only available to 64 bit processes)
		/// </summary>
		PROCESSOR_ARCHITEW6432
			,
		/// <summary>
		/// Processor ID of the user's workstation.
		/// </summary>
		[Sys]

		PROCESSOR_IDENTIFIER
			,
		/// <summary>
		/// Processor level of the user's workstation.
		/// </summary>
		[Sys]
		PROCESSOR_LEVEL
			,
		/// <summary>
		/// Processor version of the user's workstation.
		/// </summary>
		[Sys]
		PROCESSOR_REVISION
			,
		/// <summary>
		/// C:\ProgramData
		/// </summary>
		[Shell]
		ProgramData
			,
		/// <summary>
		/// C:\Program Files or C:\Program Files (x86)
		/// </summary>
		[Shell]

		ProgramFiles
			,
		/// <summary>
		/// C:\Program Files (x86)   (but only available when running under a 64 bit OS)
		/// </summary>
		/// <remarks>
		///Only on 64 bit systems, is used to store 32 bit programs.
		/// </remarks>
		///
		[Shell, Description("ProgramFiles(x86)")]
		ProgramFiles_x86_
			,
		/// <summary>
		/// =%ProgramFiles%(but only available when running under a 64 bit OS)
		/// </summary>
		ProgramW6432
			,
		/// <summary>
		/// Code for current command prompt format,usually $P$G
		/// C:>
		/// </summary>
		[Shell]
		PROMPT
			,
		/// <summary>
		/// %SystemRoot%\system32\WindowsPowerShell\v1.0\Modules\
		/// </summary>
		[Sys]
		PSModulePath
			,
		/// <summary>
		/// C:\Users\Public
		/// </summary>
		///
		[Shell]
		Public
			,
		/// <summary>
		/// Terminal servers only - for a terminal server session, SessionName is a combination of the connection name, followed by #SessionNumber. For a console session, SessionName returns "Console".
		/// </summary>

SessionName

			,
		/// <summary>
		/// without enclosing "%%";
		/// %SystemDrive%
		/// </summary>
		SystemDrive,

		/// <summary>
		/// %SystemRoot% is a built-in variable (along with a small handful of others like %SystemDrive%). That is, it is not actually defined in the environment variable store at HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Environment in the registry.
		/// </summary>
		SystemRoot

			,
		/// <summary>
		/// C:\Users\{Username}\AppData\Local\Temp
		/// Under XP this was \{username}\Local Settings\Temp
		/// </summary>
		[Shell]

		Temp
			,
		/// <summary>
		/// C:\Users\{Username}\AppData\Local\Temp
		/// Under XP this was \{username}\Local Settings\Temp
		/// </summary>
		/// same as <see cref="Temp"/>
		[Shell]
		Tmp
			,
		/// <summary>
		/// The current time using same format as TIME.
		/// </summary>
		[Dynamic]
TIME
			,
		/// <summary>
		/// Set if a user is a logged on to a domain and returns the fully qualified DNS domain that the currently logged on user's account belongs to.
		/// </summary>
		[Logon,Usr]
UserDnsDomain
			,
		/// <summary>
		/// {userdomain}
		/// </summary>
		[Logon,Shell]
USERDOMAIN
			,
		/// <summary>
		/// The user domain for RDS or standard roaming profile paths. Windows 8/10/2012.
		/// </summary>
		[Logon]
USERDOMAIN_roamingprofile
			,
		/// <summary>
		/// Defined as "SYSTEM", resolves as {username}
		/// </summary>
		[Logon,Sys]
USERNAME
			,
		/// <summary>
		/// %SystemDrive%\Users\{username}
		/// This is equivalent to the $HOME environment variable in Unix/Linux
		/// </summary>
		[Logon,Shell]
USERPROFILE
		,

		/// <summary>
		/// A random integer number, anything from 0 to 32,767 (inclusive).
		/// </summary>
		RANDOM,

		/// <summary>
		/// %windir% can be changed and is set by default as windir=%SystemRoot% . The OS relies on %SystemRoot%. According to Wikipedia, %WinDir% pre-dates Windows NT and seems to be superseded by %SystemRoot%.
		/// </summary>
		/// <remarks>
		/// Set by default as windir=%SystemRoot%
		/// %WinDir% pre-dates Windows NT, its use in many places has been replaced by the system variable: %SystemRoot%
		/// </remarks>
		///
		[Sys]
		WinDir

	}
}
