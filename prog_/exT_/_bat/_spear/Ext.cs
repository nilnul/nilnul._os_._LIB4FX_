using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.exT_._bat._spear
{
	public class Ext : nilnul.fs._address.doc_._exted.Ext
	{
		public const string AFT_DOT = "bat";
		public Ext() : base(AFT_DOT)
		{
		}

		static public Ext Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Ext>.Instance;
			}
		}


	}
}
