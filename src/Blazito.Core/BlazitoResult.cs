namespace Blazito.Core
{
	public class BlazitoResult
	{
		public BlazitoInstruction Instruction { get; }
		public long ExitCode { get; }
		public string StandardOutput { get; }
		public string ErrorOutput { get; }
	}
}