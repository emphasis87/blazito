using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace Blazito.Core
{
	public class IgnoreInstruction
	{
		public string Instruction { get; }
		public bool IsNegative { get; }


		public IgnoreInstruction(string instruction)
		{
			if (instruction.StartsWith("!"))
			{
				instruction = instruction.Substring(1);
				IsNegative = true;
			}

			Instruction = instruction;
		}

		public bool IsMatch(string path)
		{
			return false;
		}
	}
}