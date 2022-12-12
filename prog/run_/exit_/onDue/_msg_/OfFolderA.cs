using nilnul.fs;

namespace nilnul.os.prog.run_.exit_.onDue._msg_
{
	public abstract class OfFolderA :
	OfShieldA
		,
		OfFolderI
	{
		public string msg(string cmd, string arg=null, FolderI dir=null, int? life = null, int? bye = null)
		{
			return msg(cmd,arg,dir.address.en);
		}
		public string trimmed(string cmd, string arg = null, FolderI dir = null, int? life = null, int? bye = null)
		{
			return msg(cmd, arg= null, dir= null, life,bye)?.Trim();
		}
	}

}
