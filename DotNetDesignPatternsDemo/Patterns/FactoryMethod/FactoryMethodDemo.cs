namespace DotNetDesignPatternsDemo.Patterns.FactoryMethod;

/// <summary>
/// Factory Method: define an interface for creating an object, but let subclasses decide which class to instantiate.
/// </summary>
public interface ITransport
{
    string Deliver();
}

public class Truck : ITransport {
    public string Deliver() => "Deliver by land in a box.";}

public class Ship : ITransport  {
    public string Deliver() => "Deliver by sea in a container.";}

public abstract class Logistics
{
    /// <summary>Factory method — each concrete logistics picks the transport.</summary>
    public abstract ITransport CreateTransport();

    public string PlanDelivery()
    {
        var transport = CreateTransport();
        return transport.Deliver();
    }
}

public class RoadLogistics : Logistics
{
    public override ITransport CreateTransport() => new Truck();
}

public class SeaLogistics : Logistics
{
    public override ITransport CreateTransport() => new Ship();
}

public static class FactoryMethodDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Factory Method Pattern ===");
        Logistics road = new RoadLogistics();
        Logistics sea = new SeaLogistics();
        Console.WriteLine($"  Road: {road.PlanDelivery()}");
        Console.WriteLine($"  Sea:  {sea.PlanDelivery()}");
        Console.WriteLine();
    }
}
