// Задача 2: Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

int row = Prompt("Rows number: ");
int column = Prompt("Columns number: ");
int min = 0;
int max = 10;
int[,] array = InitArray(row, column, min, max);
PrintArray(array);
int rowPosition = Prompt("Enter a row number: ");
int columnPositiopn = Prompt("Enter a column number: ");
Console.WriteLine(FindElement(array, rowPosition, columnPositiopn));

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

void PrintArray(int[,] array)
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

string FindElement(int[,] array, int rowPosition, int columnPosition)
{
    string result = "";
    if (rowPosition < 1 || columnPosition < 1 || rowPosition > array.GetLength(0) || columnPosition > array.GetLength(1))
    {
        result = $"The element is not at the position ({rowPosition}; {columnPosition})";
    }
    else
    {
        result = $"The element at the position ({rowPosition}; {columnPosition}) is {array[rowPosition - 1, columnPosition - 1]}. ";
    }

    return result;
}