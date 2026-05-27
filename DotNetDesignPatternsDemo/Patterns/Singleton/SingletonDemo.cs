namespace DotNetDesignPatternsDemo.Patterns.Singleton;

/// <summary>
/// Singleton: ensure a class has only one instance and provide global access.
/// This demo uses Lazy&lt;T&gt; for thread-safe lazy initialization.
/// </summary>
public sealed class AppLogger
{
    private static readonly Lazy<AppLogger> LazyInstance =
        new(() => new AppLogger());

    public static AppLogger Instance => LazyInstance.Value;

    private readonly List<string> _lines = new();

    private AppLogger()
    {
        Console.WriteLine("  [Singleton] AppLogger ctor — runs once per process.");
    }

    public void Log(string message)
    {
        var line = $"{DateTime.Now:HH:mm:ss.fff} | {message}";
        _lines.Add(line);
        Console.WriteLine($"  [Log] {line}");
    }

    public IReadOnlyList<string> Snapshot() => _lines.ToList();
}

public static class SingletonDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Singleton Pattern ===");
        var a = AppLogger.Instance;
        var b = AppLogger.Instance;
        a.Log("First message");
        b.Log("Second message (same instance)");
        Console.WriteLine($"  Same instance? {ReferenceEquals(a, b)}");
        Console.WriteLine();
    }
}
