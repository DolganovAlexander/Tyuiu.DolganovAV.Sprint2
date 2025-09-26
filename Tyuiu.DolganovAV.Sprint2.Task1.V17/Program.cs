
using Tyuiu.DolganovAV.Sprint1.Task1.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int a = 135;
        int b = 123;
        int c = 455;
        int d = 321;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);

        Console.Title = "Спринт #2 | Выполнил: Долганов А. В. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логические операции                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнил: Долганов Александр Витальевич | ПИНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений и логических операций, а также *");
        Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность  *");
        Console.WriteLine("* (массив): { true, false, true, true, true, false }                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"c = {c}");
        Console.WriteLine($"d = {d}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
    }
}
