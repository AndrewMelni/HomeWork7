/*Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, и
 возвращает значение этого элемента или же указание, 
 что такого элемента нет.
*/

Console.Clear();

int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);

Console.Write("Введите строку элемента: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите столбец элемента: ");
int y = int.Parse(Console.ReadLine());
Position(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void Position (int[,] inArray)
{
    if (x > inArray.GetLength(0) || y > inArray.GetLength(1))
    {
        Console.WriteLine("Такой позиции нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента: {array[x-1, y-1]}");        
    }
}
  