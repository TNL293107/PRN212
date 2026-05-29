using Demo2.LinqExercises;

namespace Demo2;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var exercise1 = new LinqExercise1();
        exercise1.Run();

        var exercise2 = new LinqExercise2();
        exercise2.Run();

        var exercise3 = new LinqExercise3();
        exercise3.Run();

        var exercise4 = new LinqExercise4();
        exercise4.Run();

        var exercise5 = new LinqExercise5();
        exercise5.Run();

        var exercise6 = new LinqExercise6();
        exercise6.Run();
    }
}
