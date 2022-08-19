// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine("Укажите количество столбцов массива:");
int colomnNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите количество строк массива:");
int rowNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите порядковый номер элемента, который нужно найти:");
int positionOfElement = int.Parse(Console.ReadLine());

int[,] randomArray = new int [rowNumber, colomnNumber];
int limitOfRandom = 5; //задал жёстко, чтобы не перегружать пользователя запросами. Можно запросить значение для данного параметра

arrayFill(randomArray, limitOfRandom, colomnNumber, rowNumber);
printArray(randomArray, colomnNumber, rowNumber);
if(colomnNumber * rowNumber < positionOfElement)
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    Console.WriteLine("значение элемента под номером " + positionOfElement + ": " + getElementByPosition(randomArray, positionOfElement, colomnNumber, rowNumber));
}



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

int getElementByPosition (int [,] array, int position, int colomn, int row)
{
    int element = 0;
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < colomn; j++)
        {
        element++;
        if(position == element)
        {
            return array[i,j];
        }
        }
    }
    return -100;
}