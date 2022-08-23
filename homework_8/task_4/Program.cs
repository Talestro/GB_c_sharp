// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.WriteLine("Укажите количество столбцов массива:");
int colomnNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите количество строк массива:");
int rowNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите количество слоёв массива:");
int layerNumber = int.Parse(Console.ReadLine());

int[,,] randomArray = new int[rowNumber, colomnNumber, layerNumber];
int[] existingResults = new int[90];

arrayFill(randomArray);
printArray(randomArray);


void arrayFill(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j, k] = getUnicRand();
            }
        }
    }
}

void printArray(int[,,] array)
{
    Console.WriteLine("Сгенерирован массив:");
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ") ");
            }
            Console.Write("\n");
        }
    }
}

int getUnicRand()
{
    int unicNumber;
    do
    {
        unicNumber = new Random((int)DateTime.Now.Ticks).Next(10, 100);
    } while (unicCheck(existingResults, unicNumber) != true);
    addResult(existingResults, unicNumber);
    return unicNumber;
}

bool unicCheck(int[] results, int number)
{
    for (int i = 0; i < results.GetLength(0); i ++)
    {
        if (number == results[i])
        {
            return false;
        }
    }
    return true;
}

void addResult (int [] results, int unicNumber)
{
    for(int i = 0; i < results.GetLength(0); i++)
    {
        if(results[i] == 0)
        {
            results[i] = unicNumber;
            return;
        }
    }
}