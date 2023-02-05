// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputRowsColums(string str)
{
    int number;
    string?  text;
    while(true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if(int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Вы ввели не число");
    }
    return number;
}

double[,] RandomDoubleArray(int rows, int colums)
{
    Random rand = new Random();
    double[,] arr = new double[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            arr[i, j] = Math.Round(rand.Next(0, 100) + rand.NextDouble(), 3);
        }
    }
    return arr;
}

void PrintDoubleArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int m = InputRowsColums("Введите количество строк массива: ");
int n = InputRowsColums("Введите количество столбцов массива: ");
double[,] matrix = RandomDoubleArray(m, n);
PrintDoubleArray(matrix);