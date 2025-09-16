using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs._address.doc_.exted;

namespace nilnul.os.prog_.exT_._bat.spear
{
	public class Be : nilnul.fs.address_.spear.BeI
	{
		public bool be(SpearI obj)
		{
			return nilnul.fs._address.doc_._exted.ext.Eq.Singleton.eq(
				nilnul.fs._address.doc_.exted._ExtX.Ext(obj.sprig.document.doc)
				,
				_spear.Ext.Singleton
			);
		}

		static public Be Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Be>.Instance;
			}
		}

	}
}
