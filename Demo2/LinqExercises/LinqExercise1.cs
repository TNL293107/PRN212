namespace Demo2.LinqExercises;

//Bài 1: Lọc số chẵn bằng cú pháp truy vấn LINQ
public class LinqExercise1
{
    public void Run()
    {
        int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var nQuery = from tmp in n1
                     where (tmp % 2) == 0
                     select tmp;

        Console.WriteLine("--- Bài 1: Số chẵn (0–9) ---");
        Console.WriteLine(string.Join(", ", nQuery));
    }
}
