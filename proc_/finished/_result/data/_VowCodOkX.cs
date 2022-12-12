using System;

namespace nilnul.os.proc_.finished._result.data
{
	public static class _Vow_codOkX
	{

		public static void Vow(_result.CodMsgErr r)
		{
			if (r.beErr)
			{
				throw new os.proc_.finished._result.data_.xpn_.CodIsNotOkException(r.exitCode,r.err);
			}
		}

		//public static void Vow(nilnul.os.proc_.finished._result.CodMsgErr r)
		//{
		//	Vow( (_result.CodMsgErr)r);
		//}
	
	



	}
}
