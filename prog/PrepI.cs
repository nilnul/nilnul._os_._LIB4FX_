﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog
{
	public interface PrepI:IPrep
	{
		//implicit operator ProcessStartInfo(PrepI prep);
		ProcessStartInfo info { get; }
	}
}
