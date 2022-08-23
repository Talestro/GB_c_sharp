// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.WriteLine("Укажите количество столбцов матрицы А:");
int colomnNumberA = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите количество строк матрицы А:");
int rowNumberA = int.Parse(Console.ReadLine());

Console.WriteLine("Укажите количество столбцов матрицы Б:");
int colomnNumberB = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите количество строк матрицы Б:");
int rowNumberB = int.Parse(Console.ReadLine());

if (rowNumberA != colomnNumberB)
{
    Console.WriteLine("матрицы нельзя перемножить");
}
else
{
    int[,] randomArrayA = new int[rowNumberA, colomnNumberA];
    int[,] randomArrayB = new int[rowNumberB, colomnNumberB];
    int[,] multiOfAandB = new int[rowNumberA, colomnNumberB];

    arrayFill(randomArrayA);
    arrayFill(randomArrayB);
    Console.WriteLine("Матрица А:");
    printArray(randomArrayA);
    Console.WriteLine("Матрица B:");
    printArray(randomArrayB);
    getMulti(randomArrayA, randomArrayB, multiOfAandB);
    Console.WriteLine("\nРезультат перемножения:");
    printArray(multiOfAandB);
}


void arrayFill(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11); //зафиксировал, чтобы меньше запрашивать
        }
    }
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("\n");
    }
}

void getMulti(int [,] arrayA, int [,] arrayB, int[,] arrayResult)
{

    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                arrayResult[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
}
