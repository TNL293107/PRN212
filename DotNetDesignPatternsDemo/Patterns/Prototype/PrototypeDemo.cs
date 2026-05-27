namespace DotNetDesignPatternsDemo.Patterns.Prototype;

/// <summary>
/// Prototype: specify the kinds of objects to create using a prototypical instance, and create new objects by copying it.
/// </summary>
public interface IReportPrototype
{
    IReportPrototype Clone();
}

public class SalesReport : IReportPrototype
{
    public string Title { get; set; } = "";
    public List<string> Rows { get; } = new();

    public IReportPrototype Clone()
    {
        // Deep copy of mutable collection so clones do not share row list.
        var copy = new SalesReport { Title = Title + " (copy)" };
        copy.Rows.AddRange(Rows);
        return copy;
    }

    public override string ToString() => $"{Title}: [{string.Join(", ", Rows)}]";
}

public static class PrototypeDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Prototype Pattern ===");
        var template = new SalesReport { Title = "Q1 Sales" };
        template.Rows.Add("North: 100");
        template.Rows.Add("South: 200");

        var draft = (SalesReport)template.Clone();
        draft.Rows.Add("East: 50"); // only draft changes

        Console.WriteLine($"  Template: {template}");
        Console.WriteLine($"  Clone:    {draft}");
        Console.WriteLine($"  Same row list instance? {ReferenceEquals(template.Rows, draft.Rows)}");
        Console.WriteLine();
    }
}
