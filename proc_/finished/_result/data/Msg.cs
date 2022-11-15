using nilnul.fs;

namespace nilnul.os.proc_.finished._result.data
{
	public static class _MsgX
	{

		public static string Msg(CodMsgErr r)
		{
			if (r.beErr)
			{
				throw new data_.xpn_.CodIsNotOkException(r.exitCode,r.msg, r.err);
			}
			return r.msg??"";
		}



	}
}
