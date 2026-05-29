using Demo2.Models;

namespace Demo2.LinqExercises;

//Bài 6: SelectMany — là phẳng danh sách pet theo chủ, lọc tên bắt đầu bằng "S"
{
    public void Run()
    {
        PetOwner[] petOwners =
        {
            new PetOwner { Name = "Higa", Pets = new List<string> { "Scruffy", "Sam" } },
            new PetOwner { Name = "Ashkenazi", Pets = new List<string> { "Walker", "Sugar" } },
            new PetOwner { Name = "Price", Pets = new List<string> { "Scratches", "Diesel" } },
            new PetOwner { Name = "Hines", Pets = new List<string> { "Dusty" } }
        };

        var query = petOwners.SelectMany(
                petOwner => petOwner.Pets,
                (petOwner, petName) => new { petOwner, petName })
            .Where(ownerAndPet => ownerAndPet.petName.StartsWith("S"))
            .Select(ownerAndPet => new
            {
                Owner = ownerAndPet.petOwner.Name,
                Pet = ownerAndPet.petName
            });

        Console.WriteLine("--- Bài 6: SelectMany — pet tên bắt đầu bằng S ---");
        foreach (var item in query)
        {
            Console.WriteLine($"{item.Owner} → {item.Pet}");
        }
    }
}
