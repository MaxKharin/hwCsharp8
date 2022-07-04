// Задача 1: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[,] InitArray(int row, int column)
{
    var array = new double[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * 100;
        }
    }

    return array;
}

void PrintArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]:F2}" + "\t");
            }
            Console.WriteLine();
        }
    }    

int row = Prompt("Rows number: ");
int column = Prompt("Columns number: ");
double[,] array = InitArray(row, column);
PrintArray(array);