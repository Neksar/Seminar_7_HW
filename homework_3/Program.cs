// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            matrix[i, j] = rand.Next(0, 10);
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    return matrix;
}

void MiddleArifmetics(int[,] matrix)
{
    double[] arifmetics = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arifmetics[j] += matrix[i, j];
        }
        arifmetics[j] = Math.Round(arifmetics[j] / matrix.GetLength(0), 1);
    }
    System.Console.WriteLine($"Среднее арифметическое в каждом столбце равно: " + "| " + string.Join(" | ", arifmetics) + " |");
}

int rows = InputRowsColums("Введите колличество строк массива: ");
int colums = InputRowsColums("Введите количество столбцов массива: ");
int[,] matrix = FillRandomArray(rows, colums);
MiddleArifmetics(matrix);