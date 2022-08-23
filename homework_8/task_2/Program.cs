// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Укажите количество столбцов массива:");
int colomnNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите количество строк массива:");
int rowNumber = int.Parse(Console.ReadLine());
Console.WriteLine("укажите предел N который будет использован для заполнения массива случайными числами в диапазоне от 0 до N");
int limitOfRandom = int.Parse(Console.ReadLine());

int[,] randomArray = new int[rowNumber, colomnNumber];


arrayFill(randomArray, limitOfRandom);
printArray(randomArray);
Console.WriteLine((getRowOfMinSum(randomArray, colomnNumber, rowNumber) + 1) + " строка");


void arrayFill(int[,] array, int limit)
{
    limit++;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, limit);
        }
    }
}

void printArray(int[,] array)
{
    Console.WriteLine("Сгенерирован массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("\n");
    }
}

int getRowOfMinSum(int[,] array, int colomn, int row)
{
    int sumOfRow = 0;
    int minSum = -1;
    int result = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomn; j++)
        {
            sumOfRow += array[i, j];
        }
        if (minSum == -1)
        {
            minSum = sumOfRow;
        }
        if (minSum > sumOfRow)
        {
            result = i;
        }
        sumOfRow = 0;
    }
    return result;
}
