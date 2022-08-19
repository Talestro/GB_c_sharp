// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Укажите количество столбцов массива:");
int colomnNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите количество строк массива:");
int rowNumber = int.Parse(Console.ReadLine());
Console.WriteLine("укажите предел N который будет использован для заполнения массива случсайными числами в диапазоне от -N до N");
int limitOfRandom = int.Parse(Console.ReadLine());

int[,] randomArray = new int [rowNumber, colomnNumber];


arrayFill(randomArray, limitOfRandom, colomnNumber, rowNumber);
printArray(randomArray, colomnNumber, rowNumber);
getAverage(randomArray, colomnNumber, rowNumber);



void arrayFill (int [,] array, int limit, int colomn, int row)
{
    limit++;
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < colomn; j++)
        {
        array[i,j] = new Random().Next(limit * -1, limit);
        }
    }
}

void printArray (int [,] array, int colomn, int row)
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

void getAverage (int [,] array, int colomn, int row)
{
    double avereageOfColomn = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for(int j = 0; j < colomn; j++)
    {
        for(int i = 0; i < row; i++)
        {
        avereageOfColomn += array[i,j];
        }
        if(j != colomn)
        {
            Console.Write(getRound((avereageOfColomn/row)) + "; ");
        }
        else
        {
            Console.Write(getRound((avereageOfColomn/row)) + ".");
        }
        avereageOfColomn = 0;
    }
}

double getRound (double number) // для отбрасывания лишних знаков точности (не нормальное округление!)
{
    number *= 10;
    number = Math.Truncate(number);
    number /= 10;
    return number;
}