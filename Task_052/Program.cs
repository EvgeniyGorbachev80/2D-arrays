// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine();

Console.Write("Введите количество строк: ");
int a = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine();

int[,] numbers = new int[a, b];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();

void ArithmeticMeanElements(int[,] numbers)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            average = (average + numbers[i, j]);
        }
        average = average / a;
        Console.Write(Math.Round(average, 2));
        if (j != numbers.GetLength(1) - 1)
            Console.Write("; ");
    }
}
Console.Write("Среднее арифметическое каждого столбца: ");
ArithmeticMeanElements(numbers);
Console.WriteLine();
Console.WriteLine();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (j != array.GetLength(1) - 1)
                Console.Write(", ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
