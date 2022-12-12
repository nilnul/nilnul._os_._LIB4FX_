using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.proc_.finished._result
{
	/// <summary>
	/// 
	/// </summary>
	/// <see cref="ui.prog._run.Result"/>
	public class CodMsgErr:_result.CodMsg
	{
		
		public string err;


		public CodMsgErr(int errCode, string result, string err):base(errCode,result)
		{
			this.err = err??"";
		}

		static public CodMsgErr OvErr(int code, string err) {
			return new CodMsgErr(code, "",err);
		}

		//static public implicit operator nilnul.os.proc_.finished._result.CodMsgErr(CodMsgErr cme) {
		//	return new nilnul.os.proc_.finished._result.CodMsgErr(
		//		cme.exitCode
		//		,
		//		cme.msg
		//		,
		//		cme.err
		//	);
		//}

		//static public implicit operator CodMsgErr(nilnul.os.proc_.finished._result.CodMsgErr cme) {
		//	return new CodMsgErr(
		//		cme.exitCode
		//		,
		//		cme.msg
		//		,
		//		cme.err
		//	);
		//}


		/*//  sometimes the err  has some txt */

		public override string ToString()
		{
			var guid = Guid.NewGuid().ToString();


			var hyphenRepeated = nilnul.txt.op_.unary_.RepeatX.Repeat("-", 10+ new Random().Next(10) );

			var sep = $"{hyphenRepeated}{guid}{hyphenRepeated}";
			var sepNewline = $"{sep}{Environment.NewLine}";
			var sepNewPara = $"{sepNewline}{Environment.NewLine}";


			return $@"
{sep}
msg:
{sep}

{msg}

{sep}
err:
{sep}

{err}

{sep}
cod:
{sep}

{exitCode}
";	
		}

		

	}
}
