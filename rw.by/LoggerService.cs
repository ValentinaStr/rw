namespace rw.by
{
	public sealed class LoggerService
	{
		private const string PATH = @"D:\projects\dotnet\New folder (2)\ValentinaStr\rw\MyLog.txt";
		internal async Task WriteLogAsync(string message)
		{
			using (StreamWriter sw = new StreamWriter(PATH, true, System.Text.Encoding.Default))
			{
				await sw.WriteLineAsync(message);
			}
		}

	}
}
