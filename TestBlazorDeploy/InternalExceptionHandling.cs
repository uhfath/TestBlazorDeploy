namespace TestBlazorDeploy
{
	public static class InternalExceptionHandling
	{
		public static void Init()
		{
			AppDomain.CurrentDomain.FirstChanceException += (s, e) =>
			{
				Console.WriteLine("FIRST_CHANCE");
			};
			Console.WriteLine("INITIALIZED");
		}
	}
}
