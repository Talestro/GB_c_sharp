// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] randomArray = new int[8]; //размер задан жёстко из-за условия задачи. Можно заменить на задаваемую пользователем длинну

ArrayFill(randomArray);
ArrayPrint(randomArray);


void ArrayFill (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,1000);  // поскольку не оговрены пределы чисел в массиве - выбрано 1000, можно заменить на переменную-предел по запросу пользователя
    }
}

void ArrayPrint (int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
    Console.Write("]");
}