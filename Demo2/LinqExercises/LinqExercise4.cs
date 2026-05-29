namespace Demo2.LinqExercises;

//Sắp xếp giảm dần và lấy 5 phần tử đầu
public class LinqExercise4
{
    public void Run()
    {
        List<int> numbers = new List<int> { 6, 0, 999, 11, 443, 6, 1, 24, 54 };
        var top5 = numbers.OrderByDescending(x => x).Take(5);

        Console.WriteLine("--- Bài 4: Top 5 số lớn nhất ---");
        Console.WriteLine(string.Join(", ", top5));
    }
}
