// Zadacha47();
// Zadacha50();
// Zadacha52();


void Zadacha47()
{
    // Задача 47. Задайте двумерный массив размером m×n,
    // заполненный случайными вещественными числами.

    Console.Clear();
    Console.Write("Введите m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m, n];
    FillArray(array);
    PrintArray(array);

}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] array)
{
    Random generator = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(-100, 100) * 0.15;
        }
    }
}


void Zadacha50()
{
    // Задача 50. Напишите программу, которая на вход принимает
    // позиции элемента в двумерном массиве, и возвращает
    // значение этого элемента или же указание, что такого элемента нет.

    Console.Clear();

    Random random = new Random();
    int rows = random.Next(1, 9);
    int columns = random.Next(1, 9);
    int[,] arrayNew = new int[rows, columns];
    FillArrayInt(arrayNew);
    PrintArrayNew(arrayNew);
    FindElementValue(arrayNew, rows, columns);

}
void FillArrayInt(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(-10, 11);
        }
    }
}

void PrintArrayNew(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void FindElementValue(int[,] elementArray, int rows, int columns)
{
    Console.Write("Введите индекс строки: ");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    int l = Convert.ToInt32(Console.ReadLine());
    if (k < rows & l < columns)
    { Console.WriteLine(elementArray[k, l]); }
    else { Console.WriteLine("Элемента с такой позицией в массиве нет!"); }
}

void Zadacha52()
{
    // Задача 52. Задайте двумерный массив из целых чисел.
    // Найдите среднее арифметическое элементов в каждом столбце.

    Console.Clear();

    Random random = new Random();
    int rows = random.Next(2, 9);
    int columns = random.Next(2, 9);
    int[,] arrayOfInteger = new int[rows, columns];
    FillArrayInt(arrayOfInteger);
    PrintArrayNew(arrayOfInteger);
    AverageElementArray(arrayOfInteger);
}

void AverageElementArray(int[,] arrayElemAverage)
{
    double rowsSize = arrayElemAverage.GetLength(0);
    int columnsSize = arrayElemAverage.GetLength(1);
    for (int iColumns = 0; iColumns < columnsSize; iColumns++)
    {
        double sumColumnsElement = 0;
        double сolumnsAverage = 0;
        for (int iRows = 0; iRows < rowsSize; iRows++)
        {
            sumColumnsElement = sumColumnsElement + arrayElemAverage[iRows, iColumns];
        }
        сolumnsAverage = sumColumnsElement / rowsSize;   //мы здесь переменную rowsSize использовали вместо количества элементов столбца массива
        Console.WriteLine($"Среднее арифметическое элементов {iColumns + 1}го столбца:  {Math.Round(сolumnsAverage, 2)}");
    }
}

