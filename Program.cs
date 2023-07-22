
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }


// double[,] Create2DArray(int rows, int cols)
// {
//     return new double[rows, cols];
// }


// void Fill2DArray(double[,] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.NextDouble() * 100;
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]:F2}\t");
//         Console.WriteLine();
//     }
// }

// int rows = InputNum("Введите количество строк m: ");
// int columns = InputNum("Введите количество столбцов n: ");

// double[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray);
// Print2DArray(myArray);





// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }


// int[,] Create2DArray(int rows, int cols)
// {
//     return new int[rows, cols];
// }


// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }

// void FindValue(int[,] array, int m, int n)
// {
//     if (m <= 0 || n <= 0)
//         {Console.WriteLine("Введите правильный номер");}
//     else if (m <= array.GetLength(0) && n <= array.GetLength(1))
//         Console.WriteLine($"Значение элемента {array[m-1,n-1]}");
//     else Console.WriteLine("Такого элемента нет");
// }


// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }

// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");
// int iValue = InputNum("Введите номер строки нужного элемента: ");
// int jValue = InputNum("Введите номер столбца нужного элемента: ");

// int[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// FindValue(myArray, iValue, jValue);




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}


void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

void AverageColumn(int[,] array)
{   
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.WriteLine($"Среднеарифметическое столбца {j+1} равно { sum / array.GetLength(0):F2} ");
}
}

    int rows = InputNum("Введите количество строк: ");
    int columns = InputNum("Введите количество столбцов: ");
    int minValue = InputNum("Введите минимальное значение диапазона: ");
    int maxValue = InputNum("Введите максимальное значение диапазона: ");

    int[,] myArray = Create2DArray(rows, columns);
    Fill2DArray(myArray, minValue, maxValue);
    Print2DArray(myArray);
    AverageColumn(myArray);