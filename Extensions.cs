using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACManager
{
	public static class Extensions
	{
		public static string ReadZeroTerminatedString(this BinaryReader reader)
		{
			string ret = "";
			while (reader.BaseStream.Position < reader.BaseStream.Length && reader.PeekChar() != 0)
			{
				ret += reader.ReadChar();
			}
			return ret;
		}
	}
}
