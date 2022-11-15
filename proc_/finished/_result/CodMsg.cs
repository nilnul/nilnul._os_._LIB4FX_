using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.finished._result
{
	/// <summary>
	/// explained cod
	/// </summary>
	public class CodMsg
	{
		
		public string msg;
		public int exitCode;


		public CodMsg(int errCode, string result)
		{
			this.exitCode = errCode;
			this.msg = result??"";
		}


		public bool beErr
		{
			get { return exitCode != 0; }//  sometimes the err  has some txt|| nilnul.txt.nulable.be_.NeitherNulNorWhite.Singleton.be(err); }
		}


		public bool notBeErr
		{
			get { return !beErr; }
		}

		public override string ToString()
		{
			return $"{exitCode}:{msg}";	
		}

		public string msg0Nul4err { get { return beErr ? null : msg; } }
		public string msg0Nul4errTrimmed { get { return nilnul.txt.nulable.op_.unary_._TrimX.Op(msg0Nul4err); } }

		public string msgThrowErr {
			get {
				if (beErr)
				{
					throw new _result.cod_.ok_.ErrException(exitCode);
				}
				return msg ?? "";
			}
		}

	}
}
