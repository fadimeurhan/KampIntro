namespace OOP3
{
    internal partial class DatabaseLoggerService
    {
        internal class FilebaseLoggerService : ILoggerService
        {
            public void Log()
            {
                Console.WriteLine("dosyaya loglandı.");
            }

        }
    }

}
