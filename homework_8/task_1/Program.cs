// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.WriteLine("Укажите количество столбцов массива:");
int colomnNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите количество строк массива:");
int rowNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите предел N, от 0 до которого будет использоваться числа для заполнения массива");
int limitOfRandom = int.Parse(Console.ReadLine());

int[,] randomArray = new int[rowNumber, colomnNumber];


arrayFill(randomArray, limitOfRandom);
printArray(randomArray);
sortByRow(randomArray);
Console.WriteLine("result");
printArray(randomArray);



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

//"по убыванию" это от большего к меньшему и слева направо - исходя из этого, в примере, скорее всего допущена ошибка, т.к. там сортировка - по возрастанию. Делал по ТЗ (т.е. по убыванию)
void sortByRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] <= array[i, k])
                {
                    continue;
                }
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
}
