// Задача 3: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int row = Prompt("Rows number: ");
int column = Prompt("Columns number: ");
int min = 0;
int max = 10;
int[,] array = InitArray(row, column, min, max);
Print2DArray(array);
double[] averageNumber = FindAverageOfEachColumn(array);
Console.WriteLine("Average number of each column is ");
PrintArray(averageNumber);

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] InitArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }

    return array;
}

void Print2DArray(int[,] array)
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

void PrintArray(double[] array)
{
    foreach (double element in array)
    {
        Console.WriteLine($"{element:F2}; ");
    }

    Console.WriteLine();
}

double[] FindAverageOfEachColumn(int[,] array)
{
    double[] average = new Double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }

        average[j] = sum / array.GetLength(0);
    }

    return average;
}