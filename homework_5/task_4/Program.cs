// Дополнительное задание - задача, которую мы не успели решить на вебинаре. Если пойдет сложно, то разберем в начале следующего занятия.
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Укажите размер массива:");
int sizeOfArray = int.Parse(Console.ReadLine());

int[] randomArray = new int [sizeOfArray];
int[] resultArray = new int [sizeOfArray / 2];

if(sizeOfArray % 2 != 0)
{
    Array.Resize(ref resultArray, resultArray.Length + 1);     
}

ArrayFill(randomArray);
Console.WriteLine("Сгенерирован массив:");
printArray(randomArray);
getResultArrayOfElementMulti(randomArray, resultArray);
Console.WriteLine("\nРезультат произведения пар чисел: ");
printArray(resultArray);



void ArrayFill (int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 11);       //задал фиксированный предел, чтобы в очередной раз не запрашивать пользователя (можно заменить на переменную-предел, по аналогии с предыдущими задачами)
    }
}

void printArray (int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void getResultArrayOfElementMulti (int [] array, int [] resultArray)
{
    int k = 0;
    int j = array.Length - 1;
    for(int i = 0; i < array.Length / 2; i++)
    {
        resultArray[k] = array[i] * array[j];
        k++;
        j--;
    }
    if(array.Length % 2 != 0) //добавление последнего результата, если первый массив был с нечётным числом элементов
    {
        resultArray[k] = array[array.Length / 2];
    }
}