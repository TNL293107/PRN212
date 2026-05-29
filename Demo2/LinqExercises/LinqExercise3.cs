namespace Demo2.LinqExercises;

//Bài 3: Cú pháp phương thức — chuỗi độ dài ≥ 5, chuyển chữ hoa
public class LinqExercise3
{
    public void Run()
    {
        List<string> animals = new List<string> { "zebra", "elephant", "cat", "dog", "rhino", "bat" };
        var selectedAnimals = animals.Where(s => s.Length >= 5).Select(x => x.ToUpper());

        Console.WriteLine("--- Bài 3: Độ dài >= 5, chữ hoa ---");
        Console.WriteLine(string.Join(", ", selectedAnimals));
    }
}
