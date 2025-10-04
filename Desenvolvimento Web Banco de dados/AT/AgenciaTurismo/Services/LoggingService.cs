using System.Collections.Concurrent;
using System.IO;

namespace AgenciaTurismo.Services
{
    public class LoggingService
    {
        private readonly string _logsDir;
        private readonly string _logFile;
        private readonly ConcurrentQueue<string> _memoryLogs = new();

        public LoggingService(IWebHostEnvironment env)
        {
            _logsDir = Path.Combine(env.ContentRootPath, "Logs");
            Directory.CreateDirectory(_logsDir);
            _logFile = Path.Combine(_logsDir, "app.log");
        }

        public void LogToConsole(string msg) => Console.WriteLine(msg);

        public void LogToFile(string msg)
        {
            var line = $"{DateTime.UtcNow:O} - {msg}{Environment.NewLine}";
            File.AppendAllText(_logFile, line);
        }

        public void LogToMemory(string msg)
        {
            _memoryLogs.Enqueue($"{DateTime.UtcNow:O} - {msg}");
        }

        public IReadOnlyCollection<string> GetMemoryLogs() => _memoryLogs.ToArray();
        public string ReadFileLogs() => File.Exists(_logFile) ? File.ReadAllText(_logFile) : "";
    }
}
