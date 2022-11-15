using Newtonsoft.Json;
using System;

namespace nilnul.os.proc_.finished._result.data_.xpn_
{
	[System.Serializable]
	public class CodIsNotOkException : Exception
	{
		public CodIsNotOkException() { }
		public CodIsNotOkException(string message) : base(message) { }

		public CodIsNotOkException(int exitCode, string msg, string err):this(JsonConvert.SerializeObject(
			new { cod=exitCode, msg=msg, err=err}
		))
		{
		}

		public CodIsNotOkException(CodMsgErr r):this(r.exitCode,r.msg, r.err)
		{
		}

		public CodIsNotOkException(int exitCode, string err):this($"{exitCode.ToString()}:{err}")
		{
		}

		public CodIsNotOkException(string message, Exception inner) : base(message, inner) { }
		protected CodIsNotOkException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
