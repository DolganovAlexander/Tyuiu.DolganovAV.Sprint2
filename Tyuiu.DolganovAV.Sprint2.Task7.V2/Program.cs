using Tyuiu.DolganovAV.Sprint2.Task7.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Долганов А. В. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов к спринту                  *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Долганов Александр Витальевич | ПИНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает исходные данные и вычисляет,    *");
        Console.WriteLine("* находится ли точка с координатами X, Y в заштрихованной области.        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите X:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите Y:");
        double y = Convert.ToDouble(Console.ReadLine());
        

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (ds.CheckDotInShadedArea(x,y) == true)
        {
            Console.WriteLine($"Точка находится в закрашенной области ({ds.CheckDotInShadedArea(x, y)})");
        }
        else
        {
            {
                Console.WriteLine($"Точка не находится в закрашенной области ({ds.CheckDotInShadedArea(x, y)})");
            }
        }
    }
}