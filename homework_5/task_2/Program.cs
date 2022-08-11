// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Укажите размер массива:");
int sizeOfArray = int.Parse(Console.ReadLine());
Console.WriteLine("От 0 до какого значения (включительно) могут быть использованы случайные числа при заполнении массива?:");
int limitOfRandom = int.Parse(Console.ReadLine());

int[] randomArray = new int [sizeOfArray];

ArrayFill(randomArray, limitOfRandom);
printArray(randomArray);
Console.Write("\nсумма нечётных элементов массива: " + getSum(randomArray));



void ArrayFill (int [] Array, int limit)
{
    limit++;        //чтобы корректно отображалась граница ранлдома
    for(int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(0, limit);
    }
}

void printArray (int [] Array)
{
    Console.WriteLine("Сгенерирован массив:");
    for(int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
}

int getSum (int [] Array)    //по аналогии с задачей здесь также можно было сократить код не используя функции. Но уже вторая похожая задача, а значит некоторые функции могли бы упростить код суммарно
{
    int sum = 0;
    for(int i = 1; i < Array.Length; i += 2)
    {
        sum += Array[i];
    }
    return sum;
}
