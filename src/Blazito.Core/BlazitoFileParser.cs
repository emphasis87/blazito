using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Blazito.Core
{
	public class BlazitoFileParser
	{
		public BlazitoInstruction[] Parse(string path)
		{
			var pattern = new Regex("([a-zA-Z]+)(.*)", RegexOptions.Compiled);
			var instructions = new List<BlazitoInstruction>();
			var count = 0;
			using (var reader = new StreamReader(path))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					if (string.IsNullOrWhiteSpace(line))
						continue;

					if (line[0] == '#')
					{
						// Considered a comment for now
						continue;
					}

					var m = pattern.Match(line);
					if (!m.Success)
						throw new NotSupportedException($"Line {count}: Instruction not recognized: {line}");

					var iName = m.Groups[1].Value;
					var iContent = m.Groups[2].Value;
					var instruction = new BlazitoInstruction(iName, iContent);

					instructions.Add(instruction);

					count++;
				}
			}

			return instructions.ToArray();
		}
	}
}