﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog.prep
{

	public interface ProcI: nilnul.os.IProc
	{
		Process process { get; }

	}
}