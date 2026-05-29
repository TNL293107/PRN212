using Demo2.Models;

namespace Demo2.LinqExercises;

//Bài 5: Sắp xếp mảng Pet theo tuổi tăng dần
public class LinqExercise5
{
    public void Run()
    {
        Pet[] pets =
        {
            new Pet { Name = "Barley", Age = 8 },
            new Pet { Name = "Boots", Age = 4 },
            new Pet { Name = "Whiskers", Age = 1 }
        };

        IEnumerable<Pet> query = pets.OrderBy(pet => pet.Age);

        Console.WriteLine("--- Bài 5: Pet sắp xếp theo Age ---");
        foreach (var pet in query)
        {
            Console.WriteLine($"{pet.Name}: {pet.Age} tuổi");
        }
    }
}
