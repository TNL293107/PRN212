using DotNetDesignPatternsDemo.Patterns.AbstractFactory;
using DotNetDesignPatternsDemo.Patterns.FactoryMethod;
using DotNetDesignPatternsDemo.Patterns.Prototype;
using DotNetDesignPatternsDemo.Patterns.Singleton;

Console.WriteLine(".NET Design Patterns Demo");
Console.WriteLine("=========================");
Console.WriteLine();

SingletonDemo.Run();
FactoryMethodDemo.Run();
AbstractFactoryDemo.Run();
PrototypeDemo.Run();

Console.WriteLine("Done. Open the Patterns folder to read each implementation.");
