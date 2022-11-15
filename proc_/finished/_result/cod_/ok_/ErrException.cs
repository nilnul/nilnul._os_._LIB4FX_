using System;

namespace nilnul.os.proc_.finished._result.cod_.ok_
{
	/// <summary>
	/// not ok
	/// </summary>
	[System.Serializable]
	public class ErrException : Exception
		,
		IOk
	{
		public ErrException() { }
		public ErrException(string message) : base(message) { }

		public ErrException(int exitCode):this(exitCode.ToString())
		{
		}

		public ErrException(string message, Exception inner) : base(message, inner) { }
		protected ErrException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
