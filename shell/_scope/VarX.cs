namespace nilnul.os.shell._scope
{
	/*https://ss64.com/nt/set.html*/
	static public class VarX
	{
		/// <summary>
		/// when a var is used in batch or in pass on, '%' might be escpaed by repeating it as "%%";
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public string Wrap(string x)
		{
			return $"%{x}%";
		}

	}
}
