namespace DotNetDesignPatternsDemo.Patterns.AbstractFactory;

/// <summary>
/// Abstract Factory: provide an interface for creating families of related objects without specifying concrete classes.
/// </summary>
public interface IButton
{
    string Render();
}

public interface ICheckbox
{
    string Render();
}

public class WinButton : IButton
{
    public string Render() => "Windows button (Win32 style)";
}

public class WinCheckbox : ICheckbox
{
    public string Render() => "Windows checkbox";
}

public class MacButton : IButton
{
    public string Render() => "macOS button (Aqua style)";
}

public class MacCheckbox : ICheckbox
{
    public string Render() => "macOS checkbox";
}

public interface IGuiFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

public class WinGuiFactory : IGuiFactory
{
    public IButton CreateButton() => new WinButton();
    public ICheckbox CreateCheckbox() => new WinCheckbox();
}

public class MacGuiFactory : IGuiFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}

public static class AbstractFactoryDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Abstract Factory Pattern ===");
        RenderUi(new WinGuiFactory(), "Windows");
        RenderUi(new MacGuiFactory(), "macOS");
        Console.WriteLine();
    }

    private static void RenderUi(IGuiFactory factory, string theme)
    {
        var button = factory.CreateButton();
        var checkbox = factory.CreateCheckbox();
        Console.WriteLine($"  [{theme}] {button.Render()}");
        Console.WriteLine($"  [{theme}] {checkbox.Render()}");
    }
}
