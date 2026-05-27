# .NET Design Patterns Demo

Console application demonstrating four classic creational patterns in C# (.NET 8).

## Run

From the repository root (opens `DotNetDesignPatternsDemo.slnx` in Visual Studio 2022+), or from the project folder:

```bash
cd DotNetDesignPatternsDemo
dotnet run
```

Build the whole solution:

```bash
dotnet build DotNetDesignPatternsDemo.slnx
```

## Patterns

| Pattern | Purpose | Location |
|--------|---------|----------|
| **Singleton** | One shared instance (e.g. logger) | `Patterns/Singleton/SingletonDemo.cs` |
| **Factory Method** | Subclasses choose which product to create | `Patterns/FactoryMethod/FactoryMethodDemo.cs` |
| **Abstract Factory** | Families of related UI controls per platform | `Patterns/AbstractFactory/AbstractFactoryDemo.cs` |
| **Prototype** | Clone objects without coupling to their classes | `Patterns/Prototype/PrototypeDemo.cs` |

## Quick mental model

- **Singleton** — “only one `AppLogger` in the app.”
- **Factory Method** — “`RoadLogistics` creates `Truck`; `SeaLogistics` creates `Ship`.”
- **Abstract Factory** — “`WinGuiFactory` gives Windows-style button + checkbox together.”
- **Prototype** — “duplicate a `SalesReport` and tweak the copy without rebuilding from scratch.”
