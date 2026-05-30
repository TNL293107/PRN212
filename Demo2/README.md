# Demo2 — LINQ Exercises in C#

Console application demonstrating six LINQ exercises using both **query syntax** and **method syntax** in C# (.NET 10).

## Project Structure

```
Demo2/
├── LinqExercises/
│   ├── LinqExercise1.cs   # Filter even numbers (query syntax)
│   ├── LinqExercise2.cs   # Multiple where clauses (query syntax)
│   ├── LinqExercise3.cs   # String filtering + projection (method syntax)
│   ├── LinqExercise4.cs   # OrderByDescending + Take (method syntax)
│   ├── LinqExercise5.cs   # Sort objects by property (method syntax)
│   └── LinqExercise6.cs   # SelectMany + filter across nested lists
├── Models/
│   ├── Pet.cs             # Pet model (Name, Age)
│   └── PetOwner.cs        # PetOwner model (Name, Pets)
└── Program.cs             # Entry point — runs all exercises
```

## Exercises

| # | Topic | Technique |
|---|-------|-----------|
| 1 | Filter even numbers from `0–9` | Query syntax (`from … where … select`) |
| 2 | Filter positive numbers less than 12 | Multiple `where` clauses in query syntax |
| 3 | Strings with length ≥ 5, converted to uppercase | Method syntax (`Where`, `Select`) |
| 4 | Top 5 largest numbers | `OrderByDescending` + `Take` |
| 5 | Sort `Pet[]` by age ascending | `OrderBy` on object property |
| 6 | Flatten pet names across owners, filter names starting with "S" | `SelectMany` with result selector |

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

## Run

From the `Demo2` folder:

```bash
dotnet run
```

Or from the repository root:

```bash
dotnet run --project Demo2/Demo2.csproj
```

## Sample Output

```
--- Bài 1: Số chẵn (0–9) ---
0, 2, 4, 6, 8
--- Bài 2: Số dương và nhỏ hơn 12 ---
1, 3, 6, 9, 10
--- Bài 3: Độ dài >= 5, chữ hoa ---
ZEBRA, ELEPHANT, RHINO
--- Bài 4: Top 5 số lớn nhất ---
999, 443, 54, 24, 11
--- Bài 5: Pet sắp xếp theo Age ---
Whiskers: 1 tuổi
Boots: 4 tuổi
Barley: 8 tuổi
--- Bài 6: SelectMany — pet tên bắt đầu bằng S ---
Higa → Scruffy
Higa → Sam
Ashkenazi → Sugar
Price → Scratches
```
