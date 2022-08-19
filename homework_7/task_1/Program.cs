// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Укажите количество столбцов массива:");
int colomnNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите количество строк массива:");
int rowNumber = int.Parse(Console.ReadLine());
Console.WriteLine("От 0 до какого значения (включительно) могут быть использованы целые части вещественных чисел при заполнении массива?:");
int limitOfRandom = int.Parse(Console.ReadLine());

double[,] randomArray = new double [rowNumber, colomnNumber];

arrayFill(randomArray, limitOfRandom, colomnNumber, rowNumber);
printArray(randomArray, colomnNumber, rowNumber);



void arrayFill (double [,] array, int limit, int colomn, int row)
{
    limit++;        //чтобы корректно отображалась граница рандома
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < colomn; j++)
        {
        array[i,j] = new Random().NextDouble() + Convert.ToDouble(new Random().Next(limit * -1, limit));
        array[i,j] = Math.Round(array[i,j], 1, MidpointRounding.AwayFromZero);
        }
    }
}

void printArray (double [,] array, int colomn, int row)
{
    Console.WriteLine("Сгенерирован массив:");
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < colomn; j++)
        {
        Console.Write(array[i,j] + " ");
        }
        Console.Write("\n");
    }
}