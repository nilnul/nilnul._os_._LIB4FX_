using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os_.linux
{
	/// <summary>
	/// 
	/// </summary>
	internal class IBoot
	{

		/*
		 powerOn
		bios:
			(Unified Extensible Firmware Interface) is loaded from non-volatile memory
			,run POST: power on self test
		detect devices including:cpu,ram, and storage, and choose a boot device like a disk, network server, or CdRom
		grub, boot loader, which provides a menu to choose the or or the kernel functions;

		after the kernel is ready, execute systemd, first process in user space; probing all remaining hardware, mounting files, and running a desktop ui.
		run .target files, including:
			default.target
			,basic target
			,getty.target
			,multi-user.target
			,ssh.service
		run startup scripts:
			/systemd-logind
			/etc/profile
			~/.bashrc
		user can login now

		 */
	}
}
