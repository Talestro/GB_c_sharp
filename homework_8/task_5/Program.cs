// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int size = 4;

int[,] snailArray = new int[size, size];
int[] numbersForFilling = new int[size * size];

getNumbersForFilling(numbersForFilling);
arrayFill(snailArray, numbersForFilling);
printArray(snailArray);


void getNumbersForFilling(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = number;
        number++;
    }
}


void arrayFill(int[,] array, int[] numbers)
{
    int i = 0;
    int j = 0;
    int currentNumber = 0;
    //внешний круг
    for (j = 0; j < array.GetLength(0)-1; j++)
    {
        array[i, j] = numbers[currentNumber];
        currentNumber++;
    }
    for (i = 0; i < array.GetLength(1)-1; i++)
    {
        array[i, j] = numbers[currentNumber];
        currentNumber++;
    }
    for (j = array.GetLength(0)-1; j > 0; j--)
    {
        array[i, j] = numbers[currentNumber];
        currentNumber++;
    }
    for (i = array.GetLength(1)-1; i > 0; i--)
    {
        array[i, j] = numbers[currentNumber];
        currentNumber++;
    }
    //внутренний круг
    i=1;
    for (j = 1; j < array.GetLength(0)-2; j++)
    {
        array[i, j] = numbers[currentNumber];
        currentNumber++;
    }
    for (i = 1; i < array.GetLength(1)-2; i++)
    {
        array[i, j] = numbers[currentNumber];
        currentNumber++;
    }
    for (j = array.GetLength(0)-2; j > 0; j--)
    {
        array[i, j] = numbers[currentNumber];
        currentNumber++;
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

