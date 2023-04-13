namespace rw.by
{
	public sealed class LoggerService
	{
		private static LoggerService? _instance;
		private const string PATH = @"D:\projects\dotnet\New folder (2)\ValentinaStr\rw\MyLog.txt";

		private LoggerService() { }
		public static LoggerService GetLogger()
		{
			_instance ??= new LoggerService();
			return _instance;
		}

		internal async Task WriteLogAsync(string message)
		{
			using StreamWriter sw = new(PATH, true, System.Text.Encoding.Default);
			await sw.WriteLineAsync(message);
		}

	}
}
