namespace Blazito.Core
{
	public class BlazitoInstruction
	{
		public string Name { get; }
		public string Content { get; }

		public BlazitoInstruction(string name, string content)
		{
			Name = name;
			Content = content;
		}
	}
}