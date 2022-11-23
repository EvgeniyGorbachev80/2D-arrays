// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
//            и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine();

Console.Write("Введите строку: ");
int position1 = Convert.ToInt32(Console.ReadLine()!) - 1;
Console.Write("Введите столбец: ");
int position2 = Convert.ToInt32(Console.ReadLine()!) - 1;
Console.WriteLine();

int n = 3;
int m = 4;

Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine($"Исходный массив: ");
PrintArray(arr);
PositionElement(position1, position2);

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 10);
            Console.Write("{0} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}

void PositionElement(int position1, int position2)
{
    if (position1 < 0 | position1 > arr.GetLength(0) - 1 | position2 < 0 | position2 > arr.GetLength(1) - 1)
    {
        Console.WriteLine($"{position1}{position2} -> Такого числа в массиве нет.");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", arr[position1, position2]);
    }
    Console.WriteLine();
}
