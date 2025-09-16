using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.shell._scope._var.attr_
{
	/// <summary>
	/// (update every time used
	/// </summary>
	[System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
	sealed class DynamicAttribute : Attribute
	{
		private bool _beHidden;

		public bool beHidden
		{
			get { return _beHidden; }
			set { _beHidden = value; }
		}

		public DynamicAttribute( bool isHidden=false)
		{
			_beHidden = isHidden;
		}
		
	}
	
}
