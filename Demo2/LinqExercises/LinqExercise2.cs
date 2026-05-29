namespace Demo2.LinqExercises;

//Bài 2: Nhiều mệnh đề where — số dương và nhỏ hơn 12
public class LinqExercise2
{
    public void Run()
    {
        int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
        var nQuery = from tmp in n1
                     where tmp > 0
                     where tmp < 12
                     select tmp;

        Console.WriteLine("--- Bài 2: Số dương và nhỏ hơn 12 ---");
        Console.WriteLine(string.Join(", ", nQuery));
    }
}
