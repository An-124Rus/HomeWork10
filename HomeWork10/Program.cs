internal class Program
{
    private static void Main(string[] args)
    {
        int numberForCount;

        Console.Write("Введите начальное число: ");
        int minimumNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите конечное число: ");
        int maximumNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите шаг: ");
        int step = Convert.ToInt32(Console.ReadLine());

        for (numberForCount = minimumNumber; numberForCount <= maximumNumber; numberForCount += step)
        {
            Console.WriteLine(numberForCount);
        }

        //Выбор цикла обусловлен заданными начальным и конечным значениями

        // Можно компактнее:

        // int numberForCount;

        // for (numberForCount = 5; numberForCount <= 96; numberForCount += 7)
        // {
        //     Console.WriteLine(numberForCount);
        // }
    }
}