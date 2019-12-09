using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Blazito.Core
{
	public class IgnoreFileParser
	{
		public IgnoreInstruction[] Parse(string path)
		{
			var instructions = new List<IgnoreInstruction>();
			using (var reader = new StreamReader(path))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					line = line.Trim();
					if (line.StartsWith("#"))
						continue;

					if (string.IsNullOrEmpty(line))
						continue;

					instructions.Add(new IgnoreInstruction(line));
				}
			}

			return instructions.ToArray();
		}
	}
}
