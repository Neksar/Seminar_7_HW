// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int InputRowsColums(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Вы ввели не число");
    }
    return number;
}

int[,] FillRandomArray(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = rand.Next(0, 100);
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    return matrix;
}

void FindElementInArray(int[,] matrix)
{
    int row = InputRowsColums("Введите элемент строки: ");
    int colum = InputRowsColums("Введите элемент столбца: ");
    if (row < matrix.GetLength(0) && colum < matrix.GetLength(1))
    {
        System.Console.WriteLine($"Искомый элемент - {matrix[row, colum]}");
    }
    else
    {
        System.Console.WriteLine("Такого элемента в массиве нет");
    }
}

int rows = InputRowsColums("Введите колличество строк массива: ");
int colums = InputRowsColums("Введите колличество столбцов массива: ");
int[,] num = FillRandomArray(rows, colums);
FindElementInArray(num);
